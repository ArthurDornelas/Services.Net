using HackatonApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackatonApp.Data.Mappings
{
    public class CandidatoMap : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Cpf).HasMaxLength(11).IsRequired();

            builder.Property(x => x.DataNascimento).IsRequired(false);        
        }
    }
}
