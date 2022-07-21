namespace CBO_MDE.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<Venture> Venture { get; set; }
    }
}
