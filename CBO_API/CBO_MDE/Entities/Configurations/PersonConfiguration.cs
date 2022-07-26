using CBO_MDE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBO_MDE.Entities.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("PERSONS");

            builder.HasKey(person => person.Id);

            builder.Property(person => person.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            builder.Property(person => person.MobileNumber)
                .HasColumnName("MobileNumber")
                .HasColumnType("CHAR(11)")
                .IsRequired(false);

            builder.Property(person => person.Email)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR(30)")
                .IsRequired(false);

            builder.Property(person => person.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("BIT")
                .IsRequired();
        }
    }
}
