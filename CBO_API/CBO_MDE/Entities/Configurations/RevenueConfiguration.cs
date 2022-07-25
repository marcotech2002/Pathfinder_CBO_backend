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
