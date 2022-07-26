using CBO_MDE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBO_MDE.Entities.Configurations
{
    public class RevenueObservationConfiguration : IEntityTypeConfiguration<RevenueObservation>
    {
        public void Configure(EntityTypeBuilder<RevenueObservation> builder)
        {
            builder.ToTable("REVENUES_OBSERVATIONS");

            builder.Property<int>("FkRevenue")
                .HasColumnName("FkRevenue");

            builder.HasOne(revenueObservarion => revenueObservarion.Revenue)
                .WithMany(revenue => revenue.Observations)
                .HasForeignKey("FkRevenue");
        }
    }
}
