using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class PropostaService : IPropostaService
    {
        private readonly IPropostaRepository _propostaRepository;

        public PropostaService(IPropostaRepository propostaRepository)
        {
            _propostaRepository = propostaRepository;
        }

        public async Task<ResultService<Proposta>> Create(Proposta proposta)
        {
            if (proposta == null)
                return ResultService.Fail<Proposta>("Objeto deve ser informado");

            var data = await _propostaRepository.CreateAsync(proposta);

            return ResultService.Ok(data);
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var proposta = await _propostaRepository.GetByIdAsync(id);

            if (proposta == null)
                return ResultService.Fail("Proposta não encontrada.");

            await _propostaRepository.DeleteAsync(proposta);
            return ResultService.Ok("Proposta deletada com sucesso.");
        }

        public async Task<ResultService<Proposta>> GetByIdAsync(int id)
        {
            var proposta = await _propostaRepository.GetByIdAsync(id);

            if (proposta == null)
                return ResultService.Fail<Proposta>("Proposta não encontrada");

            return ResultService.Ok(proposta);
        }

        public async Task<ResultService> UpdateAsync(Proposta proposta)
        {
            if (proposta == null)
                return ResultService.Fail("Objeto deve ser informado.");

            await _propostaRepository.EditAsync(proposta);

            return ResultService.Ok("Proposta editada com sucesso.");
        }

        public async Task<ResultService<ICollection<Proposta>>> GetByIdContratadoAsync(string idContratado)
        {
            var proposta = await _propostaRepository.GetByIdContratadoAsync(idContratado);

            if (proposta == null)
                return ResultService.Fail<ICollection<Proposta>>("Não existe nenhuma proposta com este contratado.");

            return ResultService.Ok(proposta);
        }

        public async Task<ResultService<ICollection<Proposta>>> GetAsync()
        {
            var proposta = await _propostaRepository.GetAsync();
            return ResultService.Ok(proposta);
        }
    }
}
