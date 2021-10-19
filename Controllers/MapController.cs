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
    public class MapController : ControllerBase
    {
        private readonly IMapRepository _repository;
        private readonly IMapper _mapper;
        public MapController(IMapper mapper, IMapRepository repo)
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

        [HttpGet("{id}")]
        public async Task<ActionResult<MapModel>> Get(int id)
        {
            var maps = await _repository.GetSingle(x => x.Id == id, includeProperties: "MapNodes,MapImage");
            return _mapper.Map<MapModel>(maps);
        }

        [HttpGet]
        [Route("GetBySchoolId/{schoolId}")]
        public async Task<ActionResult<MapModel[]>> GetBySchoolId(int schoolId)
        {
            try
            {
                var maps = await _repository.Get(x => x.MapImage.SchoolId == schoolId, includeProperties:"MapNodes,MapImage");
                return _mapper.Map<MapModel[]>(maps);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure" + ex);
            }

        }


        //** MOVED TO MapImageController CAN DELETE IF NOT RE-USED
        //[HttpPost]
        //public async Task<ActionResult<MapModel>> Post(NewMapModel model)
        //{
        //    try
        //    {
        //        var map = new Map
        //        {
        //            Created = DateTime.Now,
        //            Modified = DateTime.Now,
        //            MapNodes = model.MapNodes.Select(node => new MapNode
        //            {
        //                XPos = node.XPos,
        //                YPos = node.YPos,
        //                Description = node.Description,
        //            }).ToList()
        //        };
        //       // Map map = _mapper.Map<Map>(model);
        //        if (map != null)
        //        {
        //            _repository.Create(map);
                 
        //                if (await _repository.Save())
        //                {
        //                    return CreatedAtAction("Get", new { id = map.Id }, map);
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure" + ex);
        //    }
        //    return BadRequest();
        //}
    }
}
