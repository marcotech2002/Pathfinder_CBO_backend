namespace CBO_MDE.Models
{
    public class Venture
    {
        public int Id { get; set; }
        public int ContractNumber { get; set; }
        public float Value { get; set; }
        public float DRF { get; set; }
        public bool IsActive { get; set; }
        public Client Client { get; set; }
        public List<Revenue> Revenues { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
