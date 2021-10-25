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
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepository _repository;
        private readonly IMapper _mapper;
        public SubjectController(IMapper mapper, ISubjectRepository repo)
        {
            _repository = repo;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<LessonSubjectModel[]>> Get()
        {
            var controlSubjects = await _repository.GetAll();
            return _mapper.Map<LessonSubjectModel[]>(controlSubjects);
        }

        [HttpGet]
        [Route("GetByName/{name}")]
        public async Task<ActionResult<LessonSubjectModel>> GetByName(string name)
        {
            try
            {
                var controlSubjects = await _repository.GetSingle(x => x.Name == name, includeProperties: "QAs");
                return _mapper.Map<LessonSubjectModel>(controlSubjects);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure /n" + ex.InnerException);
            }
    
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ActionResult<LessonSubjectModel>> GetById(int id)
        {
            try
            {
                var controlSubjects = await _repository.GetSingle(x => x.Id == id, includeProperties: "QAs");
                return _mapper.Map<LessonSubjectModel>(controlSubjects);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure /n" + ex.InnerException);
            }
        }

        [HttpGet]
        [Route("GetByAgeGroup/{agegroup}")]
        public async Task<ActionResult<LessonSubjectModel[]>> GetByAgeGroup(string agegroup)
        {
            try
            {
                var subjects = await _repository.Get(x => x.AgeGroup.Contains(agegroup));
                return _mapper.Map<LessonSubjectModel[]>(subjects);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure /n" + ex.InnerException);
            }
        }
    }
}

