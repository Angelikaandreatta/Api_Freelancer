using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Maps
{
    public class ProjetoMap : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.ToTable("Projeto");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("IdProjeto")
                .UseIdentityColumn();

            builder.Property(c => c.IdContratado)
                .HasColumnName("IdContratado");

            builder.Property(c => c.IdContratante)
                .HasColumnName("IdContratante");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome");

            builder.Property(c => c.Descricao)
                .HasColumnName("Descricao");

            builder.Property(c => c.Valor)
               .HasColumnName("Valor");

            builder.Property(c => c.Prazo)
               .HasColumnName("Prazo");

            builder.HasOne(p => p.Contratante)
                   .WithOne()
                   .HasForeignKey<Projeto>(p => p.IdContratante);

            builder.HasOne(e => e.Contratado)
               .WithOne()
               .HasForeignKey<Projeto>(e => e.IdContratado)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
