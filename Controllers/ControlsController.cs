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
    [ApiController]
    [Route("[controller]")]
    public class ControlsController : ControllerBase
    {

        private readonly IOrienteeringRepository _repository;

        private readonly IMapper _mapper;
        public ControlsController(IMapper mapper, IOrienteeringRepository repo)
        {
            _repository = repo;
            _mapper = mapper;

        }
        // GET: ControlsController
        [HttpGet]
        public async Task<ActionResult<ControlModel[]>> Get()
        {
            var controls = await _repository.GetControls();
            var ctrls = _mapper.Map<ControlModel[]>(controls);
            return ctrls;

        }

    }
}
