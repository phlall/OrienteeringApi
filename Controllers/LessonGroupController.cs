using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrienteeringApi.Database;
using OrienteeringApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrienteeringApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[EnableCors("CorsPolicy")]
    public class LessonGroupController : ControllerBase
    {
        private readonly ILessonGroupRepository _repository;
        private readonly IQaRepository _qaRepository;
        private readonly IMapRepository _mapRepository;
        private readonly IMapper _mapper;
        public LessonGroupController(IMapper mapper, ILessonGroupRepository repo, IQaRepository qaRepo, IMapRepository mapRepo)
        {
            _mapRepository = mapRepo;
            _qaRepository = qaRepo;
            _repository = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<LessonGroupModel[]>> Get()
        {
            var controlLessons = await _repository.GetAll();
            return _mapper.Map<LessonGroupModel[]>(controlLessons);
        }

        [HttpGet]
        [Route("GetBySchool/{id}")]
        public async Task<ActionResult<LessonGroupModel[]>> GetBySchool(int id)
        {
           // var groups = await _repository.GetLessonGroupsBySchoolId(id);
            var groups = await _repository.Get(x => x.SchoolId == id, includeProperties: "LessonSubject,LessonGroupSessions,Map");
            var mapped = _mapper.Map<LessonGroupModel[]>(groups);
            return Ok(mapped);
            //return mapped;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LessonGroupFlatModel>> Get(int id)
        {
            try
            {

                LessonGroup lg = await _repository.GetLessonGroupFull(id);

                LessonGroupFlatModel lgm = new LessonGroupFlatModel
                {
                    Id = lg.Id,
                    LessonSubjectId = lg.LessonSubjectId,
                    LessonSubject = lg.LessonSubject.Name,
                    MapId = lg.MapId,
                    SchoolId = lg.SchoolId,
                    Map = new MapModel{Id = lg.Map.Id, Description = lg.Map.Description, Title = lg.Map.Title, MapImage = new MapImageChildModel
                    {
                        Id = lg.Map.MapImage.Id,
                        Image = lg.Map.MapImage.Image,
                        Title = lg.Map.MapImage.Title,
                        Description = lg.Map.MapImage.Description
                    }
                    },
                    Nodes = lg.LessonControls.Select(x => new LessonControlFlatModel
                    {
                        Id = x.Id,
                        Question = x.QuestionAnswer.Question,
                        Answer = x.QuestionAnswer.Answer,
                        XPos = x.MapNode.XPos,
                        YPos = x.MapNode.YPos,
                        Description = x.MapNode.Description
                    }).ToList(),

                };

               // var ctrl = _mapper.Map<LessonGroupModel>(lg);
                return lgm;
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure /n" + ex.InnerException);
            }
        }

        [HttpPost]
        [Route("PostLessonGroup")]
        public async Task<ActionResult<LessonGroupModel>> PostLessonGroup(LessonGroupModel groupModel)
        {

            try
            {
                var group = _mapper.Map<LessonGroup>(groupModel);
                var subjectQuestions = await _qaRepository.GetQuestions(group.LessonSubjectId);
                if (subjectQuestions.Any())
                {
                    //var lessonControls = new List<LessonControl>();
                    foreach (var question in subjectQuestions)
                    {
                        // LessonControl lc = new LessonControl { LessonGroupId = group.Id, QAId = question.Id };
                        // *** FIX THIS FOR NEW DB STRUCTURE ***
                        //group.LessonControls.Add(new LessonControl { LessonGroupId = group.Id, QAId = question.Id, XPos = 0, YPos = 0 });
                    }
                    _repository.Create(group);
                    if (await _repository.SaveChanges())
                    {
                        groupModel.Id = group.Id;
                        return CreatedAtAction("Get", new { id = group.Id }, groupModel);
                    }
                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
            return BadRequest();

        }

        [HttpPost]
        [Route("CheckDuplicate")]
        public async Task<ActionResult<LessonGroupModel>> CheckDuplicate(LessonGroupModel model)
        {
            try
            {
                var lg = await _repository.GetSingle(x =>
                    x.LessonSubjectId == model.LessonSubjectId && x.MapId == model.MapId &&
                    x.SchoolId == model.SchoolId && x.AgeGroup.ToUpper().Contains(model.AgeGroup.ToUpper()));
                if (lg != null)
                {
                    var group = _mapper.Map<LessonGroupModel>(lg);
                    return CreatedAtAction("Get", new { id = @group.Id }, @group);
                }

                return null;
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure : " + ex);
            }
        }

        [HttpPost]
        [Route("CreateLessonGroup")]
        public async Task<ActionResult<LessonGroupModel>> CreateLessonGroup(LessonGroupModel groupModel)
        {
            try
            {
                var group = _mapper.Map<LessonGroup>(groupModel);
                if (group != null)
                {
                    
                    Map map = await _mapRepository.GetSingle(x => x.Id == groupModel.MapId, includeProperties: "MapNodes");
                    List<MapNode> mapNodes = map.MapNodes;
                    List<QA> qas = await _qaRepository.Get(x => x.LessonSubjectId == groupModel.LessonSubjectId);
                    int qaCount = qas.Count;
                    var lessonControls = new List<LessonControl>();
                    for (int i = 0; i < map.MapNodes.Count; i++)
                    {
                        if (i < qaCount)
                        {
                            var qa = qas[i];
                            lessonControls.Add(new LessonControl {QAId = qa.Id, MapNodeId = mapNodes[i].Id});
                        }
                        else
                        {
                            break;
                        }
                    }
                    group.LessonControls.AddRange(lessonControls);
                    _repository.Create(group);
                    if (await _repository.SaveChanges())
                    {
                        groupModel.Id = group.Id;
                        return CreatedAtAction("Get", new { id = groupModel.Id }, groupModel);
                    }

                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure : " + ex);
            }
            return BadRequest();

        }
    }
}
