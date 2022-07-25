namespace CBO_MDE.Models
{
    public class Employee : Person
    {
        public string CPF { get; set; }
        public string MobileNumber { get; set; }
        public List<Venture> Ventures { get; set; }
    }
}
