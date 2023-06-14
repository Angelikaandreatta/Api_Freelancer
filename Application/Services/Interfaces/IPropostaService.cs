using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IPropostaService
    {
        Task<ResultService<Proposta>> Create(Proposta proposta);
        Task<ResultService<ICollection<Proposta>>> GetAsync();
        Task<ResultService<Proposta>> GetByIdAsync(int id);
        Task<ResultService<ICollection<Proposta>>> GetByIdContratadoAsync(int idContratado);
        Task<ResultService> UpdateAsync(Proposta proposta);
        Task<ResultService> DeleteAsync(int id);
    }
}
