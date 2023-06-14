using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class ContratadoRepository : IContratadoRepository
    {
        private readonly ApplicationDbContext _db;

        public ContratadoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Contratado> CreateAsync(Contratado contratado)
        {
            await _db.AddAsync(contratado);
            await _db.SaveChangesAsync();

            return contratado;
        }

        public async Task DeleteAsync(Contratado contratado)
        {
            _db.Remove(contratado);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Contratado contratado)
        {
            _db.Update(contratado);
            await _db.SaveChangesAsync();
        }

        public async Task<Contratado> GetByIdAsync(string id)
        {
            return await _db.Contratados.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Contratado> GetByLogin(string email, string senha)
        {
            return await _db.Contratados.FirstOrDefaultAsync(x => x.Email == email && x.Senha == senha);
        }
    }
}
