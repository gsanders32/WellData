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
    public class UnitTypesController : Controller
    {
        private IUnitTypeService _unitTypeService;
        public UnitTypesController(IUnitTypeService unitTypeService)
        {
            _unitTypeService = unitTypeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var unitTypes = _unitTypeService
                .GetAll()
                .ToApiModels();
            return Ok(unitTypes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var unitType = _unitTypeService.Get(id);

            if (unitType == null) return NotFound();
            return Ok(unitType.ToApiModel());
        }

        [HttpPost]
        public IActionResult Post([FromBody] UnitTypeModel unitType)
        {
            try
            {
                _unitTypeService.Add(unitType.ToDomainModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddUnitType", ex.GetBaseException().Message);
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new { Id = unitType.Id }, unitType);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UnitTypeModel updatedUnitType)
        {
            var unitType = _unitTypeService.Update(updatedUnitType.ToDomainModel());
            if (unitType == null) return NotFound();
            return Ok(unitType.ToApiModel());
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var unitType = _unitTypeService.Get(id);
            if (unitType == null) return NotFound();
            _unitTypeService.Remove(unitType);
            return NoContent();
        }
    }
}