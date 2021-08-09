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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrienteeringApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {

        private readonly ISchoolRepository _repository;
        private readonly IMapper _mapper;
        public SchoolController(IMapper mapper, ISchoolRepository repo)
        {
            _repository = repo;
            _mapper = mapper;
        }
        // GET: api/<SchoolController>
        [HttpGet]
        public async Task<ActionResult<SchoolModel[]>> Get()
        {
            var schools = await _repository.GetAll();
            return  _mapper.Map<SchoolModel[]>(schools);
        }

        // GET api/<SchoolController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SchoolModel>> Get(int id)
        {
            var school = await _repository.GetByID(id);
            return _mapper.Map<SchoolModel>(school);
        }

        [HttpGet]
        [Route("GetTeachers/{id}")]
        public async Task<ActionResult<SchoolModel>> GetTeachers(int id)
        {
            var school = await _repository.Get(x => x.Id == id, includeProperties: "Teachers");
            return _mapper.Map<SchoolModel>(school);
        }

        [HttpGet]
        [Route("GetPupils/{id}")]
        public async Task<ActionResult<SchoolModel>> GetPupils(int id)
        {
            var school = await _repository.Get(x => x.Id == id, includeProperties: "Pupils");
            return _mapper.Map<SchoolModel>(school);
        }

        [HttpGet]
        [Route("GetPupilsList/{id}")]
        public async Task<ActionResult<PupilModel[]>> GetPupilsList(int id)
        {
            var pupils = await _repository.GetPupils(id);
            return _mapper.Map<PupilModel[]>(pupils);
        }

        // POST api/<SchoolController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SchoolController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SchoolController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
