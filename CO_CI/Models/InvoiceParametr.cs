namespace CO_CI.Models
{
    public class InvoiceParametr
    {
        public int? Id { get; set; }
        public int? ContractorId { get; set; }
        public InvoiceState InvoiceState { get; set; }

        public DateTime SearchPaymentDeadlineFromDate { get; set; }

        public DateTime SearchPaymentDeadlineUpToDate { get; set; }
    }
}
