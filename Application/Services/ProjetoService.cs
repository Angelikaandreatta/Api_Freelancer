using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetoService(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public async Task<ResultService<Projeto>> Create(Projeto projeto)
        {
            if (projeto == null)
                return ResultService.Fail<Projeto>("Objeto deve ser informado");

            var data = await _projetoRepository.CreateAsync(projeto);

            return ResultService.Ok(data);
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var projeto = await _projetoRepository.GetByIdAsync(id);

            if (projeto == null)
                return ResultService.Fail("Projeto não encontrado.");

            await _projetoRepository.DeleteAsync(projeto);
            return ResultService.Ok("Projeto deletado com sucesso.");
        }

        public async Task<ResultService<Projeto>> GetByIdAsync(int id)
        {
            var projeto = await _projetoRepository.GetByIdAsync(id);

            if (projeto == null)
                return ResultService.Fail<Projeto>("Projeto não encontrado");

            return ResultService.Ok(projeto);
        }

        public async Task<ResultService> UpdateAsync(Projeto projeto)
        {
            if (projeto == null)
                return ResultService.Fail("Objeto deve ser informado.");

            await _projetoRepository.EditAsync(projeto);

            return ResultService.Ok("Projeto editado com sucesso.");
        }

        public async Task<ResultService<ICollection<Projeto>>> GetByIdContratanteAsync(int idContratante)
        {
            var projeto = await _projetoRepository.GetByIdContratanteAsync(idContratante);

            if (projeto == null)
                return ResultService.Fail<ICollection<Projeto>>("Não existe nenhum projeto com este contratante.");

            return ResultService.Ok(projeto);
        }

        public async Task<ResultService<ICollection<Projeto>>> GetAsync()
        {
            var projeto = await _projetoRepository.GetAsync();
            return ResultService.Ok(projeto);
        }
    }
}
