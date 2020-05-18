using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WellData.ApiModels;
using WellData.Core.Services;

namespace WellData.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WellsController : Controller
    {
        private IWellService _wellService;
        public WellsController(IWellService wellService)
        {
            _wellService = wellService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var wells = _wellService
                .GetAll()
                .ToApiModels();
            return Ok(wells);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var wells = _wellService.Get(id);

            if (wells == null) return NotFound();
            return Ok(wells.ToApiModel());
        }
        [Authorize]
        [HttpPost]
        public IActionResult Post([FromBody] WellModel well)
        {
            try
            {
                _wellService.Add(well.ToDomainModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddWell", ex.GetBaseException().Message);
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new { Id = well.Id }, well);
        }
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WellModel updatedWell)
        {
            var well = _wellService.Update(updatedWell.ToDomainModel());
            if (well == null) return NotFound();
            return Ok(well.ToApiModel());
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var well = _wellService.Get(id);
            if (well == null) return NotFound();
            _wellService.Remove(well);
            return NoContent();
        }
    }
}