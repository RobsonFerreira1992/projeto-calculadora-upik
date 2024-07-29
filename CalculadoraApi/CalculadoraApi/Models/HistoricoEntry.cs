namespace CalculatorApi.Models
{
    public class HistoricoEntry
    {
        public int Id { get; set; }
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string? Operation { get; set; }
        public double Result { get; set; }
        public DateTime Timestamp { get; set; }
    }
}