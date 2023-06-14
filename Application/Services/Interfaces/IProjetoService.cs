using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IProjetoService
    {
        Task<ResultService<Projeto>> Create(Projeto projeto);
        Task<ResultService<ICollection<Projeto>>> GetAsync();
        Task<ResultService<Projeto>> GetByIdAsync(int id);
        Task<ResultService<ICollection<Projeto>>> GetByIdContratanteAsync(string idContratante);
        Task<ResultService> UpdateAsync(Projeto projeto);
        Task<ResultService> DeleteAsync(int id);
    }
}
