using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropostaController : ControllerBase
    {
        private readonly IPropostaService _propostaService;

        public PropostaController(IPropostaService propostaService)
        {
            _propostaService = propostaService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] Proposta proposta)
        {
            var result = await _propostaService.Create(proposta);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("{id}/GetById")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var result = await _propostaService.GetByIdAsync(id);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] Proposta proposta)
        {
            var result = await _propostaService.UpdateAsync(proposta);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var result = await _propostaService.DeleteAsync(id);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }


        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _propostaService.GetAsync();

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("{idContratado}/GetByIdContratado")]
        public async Task<ActionResult> GetByIdContratadoAsync(int idContratado)
        {
            var result = await _propostaService.GetByIdContratadoAsync(idContratado);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
