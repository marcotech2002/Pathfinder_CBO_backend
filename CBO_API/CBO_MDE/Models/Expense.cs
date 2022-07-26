namespace CBO_MDE.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public float ExpenseValue { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<ExpenseObservation> Observations { get; set; }
        public Venture Venture { get; set; }
    }
}
