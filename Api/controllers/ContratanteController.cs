using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratanteController : ControllerBase
    {
        private readonly IContratanteService _contratanteService;

        public ContratanteController(IContratanteService contratanteService)
        {
            _contratanteService = contratanteService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] Contratante contratante)
        {
            var result = await _contratanteService.Create(contratante);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetByIdAsync(string id)
        {
            var result = await _contratanteService.GetByIdAsync(id);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] Contratante contratante)
        {
            var result = await _contratanteService.UpdateAsync(contratante);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            var result = await _contratanteService.DeleteAsync(id);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}

