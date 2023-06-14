using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratadoController : ControllerBase
    {
        private readonly IContratadoService _contratadoService;

        public ContratadoController(IContratadoService contratadoService)
        {
            _contratadoService = contratadoService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] Contratado contratado)
        {
            var result = await _contratadoService.Create(contratado);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetByIdAsync(string id)
        {
            var result = await _contratadoService.GetByIdAsync(id);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] Contratado contratado)
        {
            var result = await _contratadoService.UpdateAsync(contratado);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            var result = await _contratadoService.DeleteAsync(id);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
