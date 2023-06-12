using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class ContratanteRepository : IContratanteRepository
    {
        private readonly ApplicationDbContext _db;

        public ContratanteRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Contratante> CreateAsync(Contratante contratante)
        {
            await _db.AddAsync(contratante);
            await _db.SaveChangesAsync();

            return contratante;
        }

        public async Task DeleteAsync(Contratante contratante)
        {
            _db.Remove(contratante);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Contratante contratante)
        {
            _db.Update(contratante);
            await _db.SaveChangesAsync();
        }

        public async Task<Contratante> GetByIdAsync(int id)
        {
            return await _db.Contratantes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Contratante> GetByLogin(string email, string senha)
        {
            return await _db.Contratantes.FirstOrDefaultAsync(x => x.Email == email && x.Senha == senha);
        }
    }
}
