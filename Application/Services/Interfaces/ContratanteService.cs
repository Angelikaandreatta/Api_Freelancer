using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Interfaces
{
    public class ContratanteService : IContratanteService
    {
        private readonly IContratanteRepository _contratanteRepository;

        public ContratanteService(IContratanteRepository contratanteRepository)
        {
            _contratanteRepository = contratanteRepository;
        }

        public async Task<ResultService<Contratante>> Create(Contratante contratante)
        {
            if (contratante == null)
                return ResultService.Fail<Contratante>("Objeto deve ser informado");

            var data = await _contratanteRepository.CreateAsync(contratante);

            return ResultService.Ok<Contratante>(data);
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var usuario = await _contratanteRepository.GetByIdAsync(id);

            if (usuario == null)
                return ResultService.Fail("Contratante não encontrado.");

            await _contratanteRepository.DeleteAsync(usuario);
            return ResultService.Ok("Contratante deletado com sucesso.");
        }

        public async Task<ResultService<Contratante>> GetByIdAsync(int id)
        {
            var contratante = await _contratanteRepository.GetByIdAsync(id);

            if (contratante == null)
                return ResultService.Fail<Contratante>("Contratante não encontrado");

            return ResultService.Ok(contratante);
        }

        public async Task<ResultService<Contratante>> GetByLogin(string email, string senha)
        {
            var contratante = await _contratanteRepository.GetByLogin(email, senha);

            if (contratante == null)
                return ResultService.Fail<Contratante>("Contratante não encontrado");

            return ResultService.Ok(contratante);
        }

        public async Task<ResultService> UpdateAsync(Contratante contratante)
        {
            if (contratante == null)
                return ResultService.Fail("Objeto deve ser informado.");

            await _contratanteRepository.EditAsync(contratante);

            return ResultService.Ok("Contratante editado com sucesso.");
        }
    }
}

