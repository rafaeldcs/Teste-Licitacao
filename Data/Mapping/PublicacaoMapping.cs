using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.Mapping
{
    public class PublicacaoMapping : IEntityTypeConfiguration<Licitacao>
    {
        public void Configure(EntityTypeBuilder<Licitacao> builder)
        {
            builder.ToTable("licitacao");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Descricao)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Descricao")
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.status)
               .HasConversion(prop => prop, prop => prop)
               .IsRequired()
               .HasColumnName("status")
               .HasColumnType("int");

            builder.Property(prop => prop.Numero)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("numero")
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.DataAbertura)
                .HasConversion(prop => prop, prop => prop)
                .IsRequired()
                .HasColumnName("data_abertura")
                .HasColumnType("datetime");
        }
    }
}
