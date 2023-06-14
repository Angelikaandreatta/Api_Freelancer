using Domain.Entities;

namespace Domain.Repositories
{
    public interface IContratadoRepository
    {
        Task<Contratado> GetByIdAsync(string id);
        Task<Contratado> GetByLogin(string email, string senha);
        Task<Contratado> CreateAsync(Contratado contratado);
        Task EditAsync(Contratado contratado);
        Task DeleteAsync(Contratado contratado);
    }
}
