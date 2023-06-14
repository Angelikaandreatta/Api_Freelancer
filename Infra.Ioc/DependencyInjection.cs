using Application.Services;
using Application.Services.Interfaces;
using Domain.Repositories;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextFactory<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IContratanteRepository, ContratanteRepository>();
            services.AddScoped<IContratadoRepository, ContratadoRepository>();
            services.AddScoped<IProjetoRepository, ProjetoRepository>();
            services.AddScoped<IPropostaRepository, PropostaRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IContratanteService, ContratanteService>();
            services.AddScoped<IContratadoService, ContratadoService>();
            services.AddScoped<IProjetoService, ProjetoService>();
            services.AddScoped<IPropostaService, PropostaService>();
            return services;
        }
    }
}
