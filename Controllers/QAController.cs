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
    public class QAController : ControllerBase
    {
        private readonly IOrienteeringRepository _repository;
        private readonly IQaRepository _qaRepository;
        private readonly IMapper _mapper;
        public QAController(IMapper mapper, IOrienteeringRepository repo, IQaRepository qaRepo)
        {
            _repository = repo;
            _qaRepository = qaRepo;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<QAModel[]>> Get()
        {
            var qas = await _qaRepository.GetAll();
            return _mapper.Map<QAModel[]>(qas);

        }

        [HttpGet]
        public async Task<ActionResult<QAModel>> Get(int id)
        {
            var qas = await _qaRepository.GetByID(id);
            return _mapper.Map<QAModel>(qas);

        }

        [HttpPost]
        public async Task<ActionResult<QAModel>> Post(QAModel qa)
        {

            try
            {
                LessonSubject subject = await _qaRepository.GetLessonSubjectByName(qa.LessonSubject);
                if (subject != null) {
                    qa.LessonSubjectId = subject.Id;
                    var newQA = _mapper.Map<QA>(qa);
                    if (newQA != null)
                    {
                        _qaRepository.Create(newQA);
                        if (await _qaRepository.SaveChanges())
                        {
                            return CreatedAtAction("Get", new { id = newQA }, qa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
            return BadRequest();

        }
    }
}
