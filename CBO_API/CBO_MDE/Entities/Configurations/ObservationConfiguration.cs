using CBO_MDE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
