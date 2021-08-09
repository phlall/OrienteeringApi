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
        private readonly IMapper _mapper;
        public LessonGroupController(IMapper mapper, ILessonGroupRepository repo, IQaRepository qaRepo)
        {
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
            var groups = await _repository.Get(x => x.SchoolId == id, includeProperties: "LessonGroupSessions,LessonSubject");
            var mapped = _mapper.Map<LessonGroupModel[]>(groups);
            return Ok(mapped);
            //return mapped;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LessonGroupModel>> Get(int id)
        {
            try
            {

                var lg = await _repository.GetByID(id);
                var ctrl = _mapper.Map<LessonGroupModel>(lg);
                return ctrl;
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
                        group.LessonControls.Add(new LessonControl { LessonGroupId = group.Id, QAId = question.Id, XPos = 0, YPos = 0 });
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

        //[HttpPost]
        //[Route("PostLessonGroup")]
        //public async Task<ActionResult<LessonGroupModel>> PostLessonGroup(LessonGroupModel groupModel)
        //{

        //    try
        //    {
        //        var group = _mapper.Map<LessonGroup>(groupModel);
        //        if( group != null)
        //        {
        //           await _repository.Create(group);
        //            if (await _repository.SaveChanges())
        //            {
        //                var newLessonGroupId = group.Id;
        //                var subjectQuestions = await _qaRepository.GetQuestions(group.LessonSubjectId);
        //                if (subjectQuestions != null && subjectQuestions.Count > 0)
        //                {
        //                    foreach (var question in subjectQuestions)
        //                    {
        //                        LessonControl lc = new LessonControl { LessonGroupId = group.Id, QAId = question.Id };
        //                        _repository.Add(lc);
        //                    }
        //                    if (await _repository.SaveChanges())
        //                    {
        //                        groupModel.Id = newLessonGroupId;
        //                        return CreatedAtAction("Get", new { id = newLessonGroupId }, groupModel);
        //                    }
        //                }
        //                //groupModel.Id = group.Id;
        //                //return CreatedAtAction("Get", new { id = groupModel.Id }, groupModel);
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
        //    }
        //    return BadRequest();

        //}
    }
}
