using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Maps
{
    public class ContratanteMap : IEntityTypeConfiguration<Contratante>
    {
        public void Configure(EntityTypeBuilder<Contratante> builder)
        {
            builder.ToTable("Contratante");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("IdContratante");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome");

            builder.Property(c => c.Email)
                .HasColumnName("Email");

            builder.Property(c => c.Senha)
               .HasColumnName("Senha");

            builder.HasOne(c => c.Projeto)
                   .WithOne(a => a.Contratante)
            .HasForeignKey<Contratante>(c => c.Id);

            builder.HasOne(c => c.Projeto)
                .WithOne(p => p.Contratante)
                .HasForeignKey<Projeto>(p => p.IdContratante);
        }
    }
}
