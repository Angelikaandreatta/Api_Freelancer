using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Maps
{
    public class ContratadoMap : IEntityTypeConfiguration<Contratado>
    {
        public void Configure(EntityTypeBuilder<Contratado> builder)
        {
            builder.ToTable("Contratado");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("IdContratado");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome");

            builder.Property(c => c.Email)
                .HasColumnName("Email");

            builder.Property(c => c.Senha)
               .HasColumnName("Senha");

            builder.Property(c => c.Descricao)
               .HasColumnName("Descricao");

            builder.Property(c => c.Habilidades)
               .HasColumnName("Habilidades");

            builder.Property(c => c.Profissao)
               .HasColumnName("Profissao");

            builder.HasOne(c => c.Projeto)
                   .WithOne(a => a.Contratado)
                   .HasForeignKey<Contratado>(c => c.Id);
        }
    }
}

