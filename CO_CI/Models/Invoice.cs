using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace CO_CI.Models
{
    public class Invoice:Base
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
        public InvoiceState InvoiceState { get; set; }
        public double HoursCount { get; set; }

        public decimal HourRate { get; set; }
        public double TaxRate { get; set; }
        public List<Expense> Expenses { get; set; } = new List<Expense>();
        public decimal ExpensesAmout
        {
            get
            {
                return ExpensesAmout;
            }
            set
            {
                for (int i = 0; i < Expenses.Count; i++)
                {
                    value += Expenses[i].Amount;
                }
                ExpensesAmout = value;
            }
        }
        public decimal Amount
        {
            get
            {
                return Amount;
            }
            set
            {
                Amount = (decimal)HoursCount * HourRate + ExpensesAmout;
            }
        }

        public decimal VATAmount
        {
            get
            {
                return VATAmount;
            }
            set
            {
                VATAmount = Amount+ Amount/100*(decimal)TaxRate;
            }
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
        AccountantRejected
    }
}
