using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WellData.ApiModels;
using WellData.Core.Services;

namespace WellData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaterLevelsController : Controller
    {
        private IWaterLevelService _waterLevelService;
        public WaterLevelsController(IWaterLevelService waterLevelService)
        {
            _waterLevelService = waterLevelService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var waterLevels = _waterLevelService
                .GetAll()
                .ToApiModels();
            return Ok(waterLevels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var waterLevel = _waterLevelService.Get(id);

            if (waterLevel == null) return NotFound();
            return Ok(waterLevel.ToApiModel());
        }

        [HttpPost]
        public IActionResult Post([FromBody] WaterLevelModel waterLevel)
        {
            try
            {
                _waterLevelService.Add(waterLevel.ToDomainModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddWaterLevel", ex.GetBaseException().Message);
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new { Id = waterLevel.Id }, waterLevel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WaterLevelModel updatedWaterLevel)
        {
            var waterLevel = _waterLevelService.Update(updatedWaterLevel.ToDomainModel());
            if (waterLevel == null) return NotFound();
            return Ok(waterLevel.ToApiModel());
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var waterLevel = _waterLevelService.Get(id);
            if (waterLevel == null) return NotFound();
            _waterLevelService.Remove(waterLevel);
            return NoContent();
        }
    }
}