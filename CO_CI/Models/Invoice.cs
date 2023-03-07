using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace CO_CI.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; } 
        public string ContractorName { get; set; }
        public string ContractorEmail { get; set;}
        public string ContractorPhoneNumber { get; set;}
        public string ContractorOrder { get; set;}
        public bool VatPayer { get; set;}   
        public int BankAccountNumber { get; set;}
        public string Address { get; set; }
        public string Period { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public Сurrency Сurrency { get; set; }
        public double HoursCount { get; set; }

        public decimal HourRate { get; set; }
        public List<Expense> Expenses { get; set; } = new List<Expense>();
        public decimal Amount { get; set; }
        public decimal VATAmount { get; set; }
    }
    public enum Сurrency
    {
        USD,
        RUB,
        EUR
    }
}
