using CBO_MDE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBO_MDE.Entities.Configurations
{
    public class VentureConfiguration : IEntityTypeConfiguration<Venture>
    {
        public void Configure(EntityTypeBuilder<Venture> builder)
        {
            builder.ToTable("VENTURES");

            builder.HasKey(venture => venture.Id);

            builder.Property(venture => venture.ContractNumber)
                .HasColumnName("ContractNumber")
                .HasColumnType("INTEGER")
                .IsRequired();

            builder.Property(venture => venture.Value)
                .HasColumnName("Value")
                .HasColumnType("FLOAT")
                .IsRequired();

            builder.Property(venture => venture.DRF)
                .HasColumnName("DRF")
                .HasColumnType("FLOAT")
                .IsRequired();
            
            builder.Property(venture => venture.RegistrationDate)
                .HasColumnName("RegistrationDate")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(venture => venture.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("BIT")
                .IsRequired();

            builder.Property<int>("FkClient")
                .HasColumnName("FkClient");

            builder.HasOne(venture => venture.Client)
                .WithMany(client => client.Ventures)
                .HasForeignKey("FkClient");

            builder.HasMany(venture => venture.Revenues)
                .WithOne(revenue => revenue.Venture);

            builder.HasMany(venture => venture.Expenses)
                .WithOne(expense => expense.Venture);

            builder.HasMany(venture => venture.Employees)
                .WithMany(employee => employee.Ventures);
        }
    }
}
