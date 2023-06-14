using Domain.Entities;

namespace Domain.Repositories
{
    public interface IPropostaRepository
    {
        Task<Proposta> GetByIdAsync(int id);
        Task<ICollection<Proposta>> GetByIdContratadoAsync(string idContratado);
        Task<ICollection<Proposta>> GetAsync();
        Task<Proposta> CreateAsync(Proposta proposta);
        Task EditAsync(Proposta proposta);
        Task DeleteAsync(Proposta proposta);
    }
}
