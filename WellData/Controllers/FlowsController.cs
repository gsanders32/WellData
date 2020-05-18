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
    public class FlowsController : Controller
    {
        private IFlowService _flowService;
        public FlowsController(IFlowService flowService)
        {
            _flowService = flowService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var flows = _flowService
                .GetAll()
                .ToApiModels();
            return Ok(flows);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var flow = _flowService.Get(id);

            if (flow == null) return NotFound();
            return Ok(flow.ToApiModel());
        }
        [Authorize]
        [HttpPost]
        public IActionResult Post([FromBody] FlowModel flow)
        {
            try
            {
                _flowService.Add(flow.ToDomainModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddFlow", ex.GetBaseException().Message);
                return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new { Id = flow.Id }, flow);
        }
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FlowModel updatedFlow)
        {
            var flow = _flowService.Update(updatedFlow.ToDomainModel());
            if (flow == null) return NotFound();
            return Ok(flow.ToApiModel());
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var flow = _flowService.Get(id);
            if (flow == null) return NotFound();
            _flowService.Remove(flow);
            return NoContent();
        }
    }
}