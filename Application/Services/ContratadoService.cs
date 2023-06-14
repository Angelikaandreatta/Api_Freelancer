using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class ContratadoService : IContratadoService
    {
        private readonly IContratadoRepository _contratadoRepository;

        public ContratadoService(IContratadoRepository contratadoRepository)
        {
            _contratadoRepository = contratadoRepository;
        }

        public async Task<ResultService<Contratado>> Create(Contratado contratado)
        {
            if (contratado == null)
                return ResultService.Fail<Contratado>("Objeto deve ser informado");

            var data = await _contratadoRepository.CreateAsync(contratado);

            return ResultService.Ok(data);
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var contratado = await _contratadoRepository.GetByIdAsync(id);

            if (contratado == null)
                return ResultService.Fail("Contratado não encontrado.");

            await _contratadoRepository.DeleteAsync(contratado);
            return ResultService.Ok("Contratado deletado com sucesso.");
        }

        public async Task<ResultService<Contratado>> GetByIdAsync(int id)
        {
            var contratado = await _contratadoRepository.GetByIdAsync(id);

            if (contratado == null)
                return ResultService.Fail<Contratado>("Contratado não encontrado");

            return ResultService.Ok(contratado);
        }

        public async Task<ResultService<Contratado>> GetByLogin(string email, string senha)
        {
            var contratado = await _contratadoRepository.GetByLogin(email, senha);

            if (contratado == null)
                return ResultService.Fail<Contratado>("Contratado não encontrado");

            return ResultService.Ok(contratado);
        }

        public async Task<ResultService> UpdateAsync(Contratado contratado)
        {
            if (contratado == null)
                return ResultService.Fail("Objeto deve ser informado.");

            await _contratadoRepository.EditAsync(contratado);

            return ResultService.Ok("Contratado editado com sucesso.");
        }
    }
}
