namespace CBO_MDE.Models
{
    public class Employee : Person
    {
        public string CPF { get; set; }
        public List<Venture> Ventures { get; set; }
    }
}
