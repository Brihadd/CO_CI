using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace CO_CI.Models
{
    public class Invoice:Base
    {
        public int InvoiceId { get; set; } 
        public int ContractorId { get; set; }
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
        public InvoiceState InvoiceState { get; set; }
        public double HoursCount { get; set; }
        public decimal HourRate { get; set; }
        public double TaxRate { get; set; }
        public List<Expense> Expenses { get; set; } = new List<Expense>();
        public decimal ExpensesAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal VATAmount { get; set; }
        public decimal  ExpensesAmountCount()
        {
            decimal result = 0;
            for (int i = 0; i < Expenses.Count; i++)
                {
                result += Expenses[i].Amount;
                }
            return result;
        }
        public decimal  AmountCount()
        {
            
            return (decimal)HoursCount * HourRate + ExpensesAmountCount();

        }
        public decimal VATAmountCount()
        {
            
            return AmountCount() + AmountCount()/ 100 * (decimal)TaxRate;

        }

    }
    public enum Сurrency
    {
        USD,
        RUB,
        EUR
    }
    public enum InvoiceState
    {
        New,
        Canceled,
        ManagerApproved,
        ManagerRejected,
        AccountantApproved,
        AccountantRejected,
        Default
    }
}
