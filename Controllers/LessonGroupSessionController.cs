using AutoMapper;
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
    public class LessonGroupSessionController : ControllerBase
    {
        private readonly ILessonGroupSessionRepository _repository;
        private readonly ILessonGroupRepository _grpRepository;
        private readonly IMapper _mapper;
        public LessonGroupSessionController(IMapper mapper, ILessonGroupSessionRepository repo, ILessonGroupRepository grpRepo)
        {
            _repository = repo;
            _grpRepository = grpRepo;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LessonGroupSessionModel[]>> Get(int id)
        {
            try
            {
                var sessions = await _repository.Get(x => x.LessonGroupId == id);
                return _mapper.Map<LessonGroupSessionModel[]>(sessions);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<LessonGroupSessionModel>> Post(int id)
        {
            try
            {
                LessonGroup group = await _grpRepository.GetSingle(x => x.Id == id, includeProperties: "LessonControls");
                //var group = _mapper.Map<LessonGroup>(groupModel);
                if (group != null)
                {
                    var newSession = new LessonGroupSession { LessonGroupId = group.Id, Completed = default};
                    group.LessonGroupSessions.Add(newSession);
                   // _repository.Create(newSession);
                    if (await _repository.SaveChanges())
                    {
                        var groupModel = _mapper.Map<LessonGroupModel>(group);
                        return CreatedAtAction("Get", new { id = newSession.Id }, groupModel);
                    }

                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure" + ex.Message);
            }
            return BadRequest();

        }
    }
}
