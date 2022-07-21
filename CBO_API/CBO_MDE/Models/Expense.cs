namespace CBO_MDE.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public float ExpenseValue { get; set; }
        public Observation Observation { get; set; }
        public Venture Venture { get; set; }
    }
}
