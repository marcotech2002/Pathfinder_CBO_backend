namespace CBO_MDE.Models
{
    public class Client : Person
    {
        public string CNPJ { get; set; }
        public List<Venture> Ventures { get; set; }
    }
}
