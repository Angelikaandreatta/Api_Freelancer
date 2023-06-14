using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class PropostaRepository : IPropostaRepository
    {
        private readonly ApplicationDbContext _db;

        public PropostaRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Proposta> CreateAsync(Proposta proposta)
        {
            await _db.AddAsync(proposta);
            await _db.SaveChangesAsync();

            return proposta;
        }

        public async Task DeleteAsync(Proposta proposta)
        {
            _db.Remove(proposta);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Proposta proposta)
        {
            _db.Update(proposta);
            await _db.SaveChangesAsync();
        }

        public async Task<Proposta> GetByIdAsync(int id)
        {
            return await _db.Propostas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Proposta>> GetAsync()
        {
            return await _db.Propostas.ToListAsync();
        }

        public async Task<ICollection<Proposta>> GetByIdContratadoAsync(int idContratado)
        {
            var list = _db.Propostas.Where(x => x.IdContratado == idContratado);
            return await list.ToListAsync();
        }
    }
}
