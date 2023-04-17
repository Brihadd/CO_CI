using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CO_CI.Models
{
    public class Order:Base
    {
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public int? EmployeeId { get; set; }
      
        public Employee Employee { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set;}
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double HourRate { get; set; }
        public double MDRate { get; set; }
        public OrderState OrderState { get; set; }
        public string Info { get; set; }
    }
    public enum OrderState
    {
        NewOrder,
        Canceled,
        ManagerApproved,
        ContractorApproved,
        Active,
        Expired,
        Default
    }
}
