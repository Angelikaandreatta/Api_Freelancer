﻿using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IContratadoService
    {
        Task<ResultService<Contratado>> Create(Contratado contratado);
        Task<ResultService<Contratado>> GetByLogin(string email, string senha);
        Task<ResultService<Contratado>> GetByIdAsync(string id);
        Task<ResultService> UpdateAsync(Contratado contratado);
        Task<ResultService> DeleteAsync(string id);
    }
}
