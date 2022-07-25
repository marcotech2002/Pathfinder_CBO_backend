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
    public class ObservationConfiguration : IEntityTypeConfiguration<Observation>
    {
        public void Configure(EntityTypeBuilder<Observation> builder)
        {
            builder.ToTable("OBSERVATIONS");

            builder.HasKey(observation => observation.Id);

            builder.Property(observation => observation.ObservationText)
                .HasColumnName("ObservationText")
                .HasColumnType("VARCHAR(255)")
                .IsRequired();
        }
    }
}
