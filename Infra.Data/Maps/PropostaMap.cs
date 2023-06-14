using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Maps
{
    public class PropostaMap : IEntityTypeConfiguration<Proposta>
    {
        public void Configure(EntityTypeBuilder<Proposta> builder)
        {
            builder.ToTable("Proposta");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("IdProposta")
                .UseIdentityColumn();

            builder.Property(c => c.IdProjeto)
                .HasColumnName("IdProjeto");

            builder.Property(c => c.IdContratado)
                .HasColumnName("IdContratado");

            builder.Property(c => c.Descricao)
                .HasColumnName("Descricao");

            builder.Property(c => c.Valor)
               .HasColumnName("Valor");

            builder.Property(c => c.DataEntrega)
               .HasColumnName("DataEntrega");
        }
    }
}
