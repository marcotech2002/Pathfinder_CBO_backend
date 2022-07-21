namespace CBO_MDE.Models
{
    public class Revenue
    {
        public int Id { get; set; }
        public float RevenueValue { get; set; }
        public Observation Observation { get; set; }
        public Venture Venture { get; set; }
    }
}
