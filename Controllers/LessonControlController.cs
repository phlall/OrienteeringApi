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
    public class LessonControlController : ControllerBase
    {
        private readonly IOrienteeringRepository _repository;
        private readonly IMapper _mapper;
        public LessonControlController(IMapper mapper, IOrienteeringRepository repo)
        {
            _repository = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<LessonControlModel[]>> Get()
        {
            var controlLessons = await _repository.GetControlLessons();
            var ctrls = _mapper.Map<LessonControlModel[]>(controlLessons);
            return ctrls;

        }

        [HttpGet("{id}")]
        //[Route("GetLessonControls")]
        public async Task<ActionResult<LessonControlModel[]>> Get(int id)
        {
            var controlLessons = await _repository.GetControlLessonsById(id);
            var ctrls = _mapper.Map<LessonControlModel[]>(controlLessons);
            return ctrls;
        }

        [HttpPut]
        public async Task<IActionResult> Put(LessonControlModel model)
        {
            var controlLesson = await _repository.GetControlLessonById(model.Id);
            controlLesson.XPos = model.XPos;
            controlLesson.YPos = model.YPos;
           // var ctrls = _mapper.Map<LessonControlModel>(controlLessons);
            _repository.Update(controlLesson);
            if (await _repository.SaveChangesAsync())
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReset (int id)
        {
            List<LessonControl> lessonControls = await _repository.GetLessonControlsBylessonId(id);
            if (lessonControls.Any())
            {
                lessonControls.ForEach(c => { c.XPos = 0; c.YPos = 0; });

                if (await _repository.SaveChangesAsync())
                {
                    return NoContent();
                }
            }
            return NotFound();
        }

        //    [HttpPut]
        //[Route("PutReset")]
        //public async Task<IActionResult> PutReset(int id)
        //{
        //    List<LessonControl> lessonControls =  await _repository.GetLessonControlsBylessonId(id);
        //    if (lessonControls.Any())
        //    {
        //        lessonControls.ForEach(c => { c.XPos = 0; c.YPos = 0; });

        //        if (await _repository.SaveChangesAsync())
        //        {
        //            return NoContent();
        //        }
        //    }
        //    return NotFound();
        //}

        [HttpPost]
        public async Task<ActionResult<LessonControlModel>> PostLessonControl(LessonControlModel model)
        {
            try
            {
                //var existingControl = await _repository.GetDishByName(dishModel.Name);
                //if (existingDish != null)
                //{
                //    return BadRequest("Menu in Use");
                //}

                // Create a new Menu
                var lc = _mapper.Map<LessonControl>(model);
                _repository.Add(lc);
                if (await _repository.SaveChangesAsync())
                {
                    return _mapper.Map<LessonControlModel>(lc);
                }

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
            return BadRequest();

        }

    }
}
