namespace CO_CI.Models
{
    public class Expense:Base
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
    }
}
