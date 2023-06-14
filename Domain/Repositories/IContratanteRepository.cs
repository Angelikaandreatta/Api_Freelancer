using Domain.Entities;

namespace Domain.Repositories
{
    public interface IContratanteRepository
    {
        Task<Contratante> GetByIdAsync(string id);
        Task<Contratante> GetByLogin(string email, string senha);
        Task<Contratante> CreateAsync(Contratante contratante);
        Task EditAsync(Contratante contratante);
        Task DeleteAsync(Contratante contratante);
    }
}
