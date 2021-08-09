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
    public class PupilController : ControllerBase
    {
        private readonly IPupilRepository _repository;
        private readonly IMapper _mapper;
        public PupilController(IMapper mapper, IPupilRepository repo)
        {
            _repository = repo;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<PupilModel[]>> Get()
        {
            try
            {
                var controlSubjects = await _repository.GetAll();
            return _mapper.Map<PupilModel[]>(controlSubjects);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure /n" + ex.InnerException);
            }

        }

        [HttpGet]
        [Route("GetByName/{firstName}/{lastName}")]
        public async Task<ActionResult<PupilModel[]>> GetByName(string firstName, string lastName)
        {
            try
            {
                var controlSubjects = await _repository.Get(x => x.LastName == lastName && x.FirstName == firstName, includeProperties: "LessonGroupSessionAnswers");
                return _mapper.Map<PupilModel[]>(controlSubjects);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure /n" + ex.InnerException);
            }
    
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ActionResult<PupilModel>> GetById(int id)
        {
            try
            {
                var controlSubjects = await _repository.GetSingle(x => x.Id == id, includeProperties: "LessonGroupSessionAnswers");
                return _mapper.Map<PupilModel>(controlSubjects);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure /n" + ex.InnerException);
            }
        }
    }

  
}

