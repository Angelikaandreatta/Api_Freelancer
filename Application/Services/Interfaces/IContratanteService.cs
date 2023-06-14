using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IContratanteService
    {
        Task<ResultService<Contratante>> Create(Contratante contratante);
        Task<ResultService<Contratante>> GetByLogin(string email, string senha);
        Task<ResultService<Contratante>> GetByIdAsync(string id);
        Task<ResultService> UpdateAsync(Contratante contratante);
        Task<ResultService> DeleteAsync(string id);
    }
}
