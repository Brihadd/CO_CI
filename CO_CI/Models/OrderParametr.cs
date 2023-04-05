namespace CO_CI.Models
{
    public class OrderParametr
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int ContractorId { get; set; }
        public OrderState OrderState { get; set; }

        public DateTime SearchFromDate { get; set; }

        public DateTime SearchUpToDate { get; set; }
    }
}
