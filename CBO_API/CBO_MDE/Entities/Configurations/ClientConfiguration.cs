using CBO_MDE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBO_MDE.Entities.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("CLIENTS");

            builder.Property(client => client.CNPJ)
                .HasColumnName("CNPJ")
                .HasColumnType("CHAR(14)")
                .IsRequired();

            builder.HasMany(client => client.Ventures)
                .WithOne(venture => venture.Client);               
        }
    }
}
