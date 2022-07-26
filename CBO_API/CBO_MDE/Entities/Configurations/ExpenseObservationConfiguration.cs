using CBO_MDE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CBO_MDE.Entities.Configurations
{
    public class ExpenseObservationConfiguration : IEntityTypeConfiguration<ExpenseObservation>
    {
        public void Configure(EntityTypeBuilder<ExpenseObservation> builder)
        {
            builder.ToTable("EXPENSES_OBSERVATIONS");

            builder.Property<int>("FkExpense")
                .HasColumnName("FkExpense");

            builder.HasOne(expenseObservation => expenseObservation.Expense)
                .WithMany(expense => expense.Observations)
                .HasForeignKey("FkExpense");
        }
    }
}
