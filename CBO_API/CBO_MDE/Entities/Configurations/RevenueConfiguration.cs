using CBO_MDE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBO_MDE.Entities.Configurations
{
    public class RevenueConfiguration : IEntityTypeConfiguration<Revenue>
    {
        public void Configure(EntityTypeBuilder<Revenue> builder)
        {
            builder.ToTable("REVENUES");

            builder.HasKey(revenue => revenue.Id);

            builder.Property(revenue => revenue.RevenueValue)
                .HasColumnName("RevenueValue")
                .HasColumnType("FLOAT")
                .IsRequired();

            builder.Property(revenue => revenue.RegistrationDate)
                .HasColumnName("RegistrationDate")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.HasMany(revenue => revenue.Observations)
                .WithOne(revenueObservation => revenueObservation.Revenue);

            builder.Property<int>("FkVenture1")
                .HasColumnName("FkVenture1");

            builder.HasOne(revenue => revenue.Venture)
                .WithMany(venture => venture.Revenues)
                .HasForeignKey("FkVenture1");
        }
    }
}
