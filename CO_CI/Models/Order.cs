using System;

namespace CO_CI.Models
{
    public class Order:Base
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public int? ContractorId { get; set; }
        public string ContractorName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set;}
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double HourRate { get; set; }
        public double MDRate { get; set; }
        public OrderState OrderState { get; set; }
       
        public string Info { get; set; }
    }
    public enum OrderState
    {
        New,
        Canceled,
        ManagerApproved,
        ContractorApproved,
        Active,
        Expired
    }
}
