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
    public class MapsController : ControllerBase
    {
        private readonly IOrienteeringRepository _repository;
        private readonly IMapper _mapper;
        public MapsController(IMapper mapper, IOrienteeringRepository repo)
        {
            _repository = repo;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<MapModel[]>> Get()
        {
            var maps = await _repository.GetMaps();
            return _mapper.Map<MapModel[]>(maps);

        }

        [HttpGet]
        public async Task<ActionResult<MapModel>> Get(int id)
        {
            var maps = await _repository.GetMap(id);
            return _mapper.Map<MapModel>(maps);

        }

        [HttpGet]
        [Route("GetBySchoolId/{schoolId}")]
        public async Task<ActionResult<MapModel[]>> GetBySchoolId(int schoolId)
        {
            var maps = await _repository.GetMapsBySchoolId(schoolId);
            return _mapper.Map<MapModel[]>(maps);

        }

    }
}
