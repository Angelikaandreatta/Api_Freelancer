using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly IProjetoService _projetoService;

        public ProjetoController(IProjetoService projetoService)
        {
            _projetoService = projetoService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] Projeto projeto)
        {
            var result = await _projetoService.Create(projeto);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("{id}/GetById")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var result = await _projetoService.GetByIdAsync(id);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] Projeto projeto)
        {
            var result = await _projetoService.UpdateAsync(projeto);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var result = await _projetoService.DeleteAsync(id);
            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }


        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _projetoService.GetAsync();

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("{idContratante}/GetByIdContratante")]
        public async Task<ActionResult> GetByIdContratanteAsync(int idContratante)
        {
            var result = await _projetoService.GetByIdContratanteAsync(idContratante);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
