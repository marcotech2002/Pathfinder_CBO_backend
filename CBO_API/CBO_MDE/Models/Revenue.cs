namespace CBO_MDE.Models
{
    public class Revenue
    {
        public int Id { get; set; }
        public float RevenueValue { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<RevenueObservation> Observations { get; set; }
        public Venture Venture { get; set; }
    }
}
