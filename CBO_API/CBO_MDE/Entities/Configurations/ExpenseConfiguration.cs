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
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.ToTable("EXPENSES");

            builder.HasKey(expense => expense.Id);

            builder.Property(expense => expense.ExpenseValue)
                .HasColumnName("ExpenseValue")
                .HasColumnType("FLOAT")
                .IsRequired();

            builder.HasMany(expense => expense.Observations)
                .WithOne(expenseObservation => expenseObservation.Expense);

            builder.Property<int>("FkVenture")
                .HasColumnName("FkVenture");

            builder.HasOne(expense => expense.Venture)
                .WithMany(venture => venture.Expenses)
                .HasForeignKey("FkVenture");
        }
    }
}
