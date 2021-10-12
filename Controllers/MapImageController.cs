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
    public class MapImageController : ControllerBase
    {
        private readonly IMapImageRepository _repository;
        private readonly IMapper _mapper;
        public MapImageController(IMapper mapper, IMapImageRepository repo)
        {
            _repository = repo;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<MapImageModel[]>> Get()
        {
            var maps = await _repository.GetAll();
            return _mapper.Map<MapImageModel[]>(maps);

        }

        [HttpGet]
        [Route("GetBySchool/{schoolId}")]
        public async Task<ActionResult<MapImageModel[]>> GetBySchool(int schoolId)
        {
            try
            {
                var maps = await _repository.GetBySchool(schoolId);
                return _mapper.Map<MapImageModel[]>(maps);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure" + ex);
            }

        }

        [HttpGet]
        public async Task<ActionResult<MapImageModel>> Get(int id)
        {
            var mapImage = await _repository.GetByID(id);
            return _mapper.Map<MapImageModel>(mapImage);

        }

        [HttpPost]
        public async Task<ActionResult<MapModel>> Post(NewMapModel model)
        {
            try
            {
                MapImage mapImage = await _repository.GetByID(model.MapImage.Id);
                var map = new Map
                {
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    MapNodes = model.MapNodes.Select(node => new MapNode
                    {
                        XPos = node.XPos,
                        YPos = node.YPos,
                        Description = node.Description,
                    }).ToList()
                };
                if (map != null)
                {
                    mapImage.Maps.Add(map);
                    //_repository.Create(map);

                    if (await _repository.Save())
                    {
                        return CreatedAtAction("Get", new { id = map.Id });
                    }
                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure" + ex);
            }
            return BadRequest();
        }

    }
}
