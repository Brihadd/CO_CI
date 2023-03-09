using CO_CI.Models;
using Microsoft.EntityFrameworkCore;

namespace CO_CI.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly DataContext _context;

        public InvoiceService(DataContext context)
        {
            _context = context;
        }
        public async Task<Invoice> CreateInvoice(Invoice invoice)
        {
            invoice.Created = DateTime.Now;
            invoice.Updated = DateTime.Now;
            invoice.ExpensesAmount = invoice.ExpensesAmountCount();
            invoice.Amount= invoice.AmountCount(); 
            invoice.VATAmount=invoice.VATAmountCount();
            await _context.Invoices.AddAsync(invoice);
            await _context.SaveChangesAsync();

            return invoice;
        }

        public async Task<bool> DeleteInvoice(int invoiceId)
        {
            var invoiceToDelete = await _context.Invoices.
                 Where(x => x.InvoiceId == invoiceId).FirstOrDefaultAsync();
            if (invoiceToDelete != null)
            {
                _context.Invoices.Remove(invoiceToDelete);
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

        public async Task<Invoice[]> GetAllInvoices()
        {
            return await _context.Invoices.ToArrayAsync();
        }

        public async Task<Invoice> GetInvoiceById(int invoiceId)
        {
            return await _context.Invoices.Where(x => x.InvoiceId == invoiceId).FirstAsync();
        }

        public async Task<Invoice> UpdateInvoice(Invoice invoice)
        {
            var invoiceToUpdate = await _context.Invoices.
               Where(x => x.InvoiceId == invoice.InvoiceId).FirstOrDefaultAsync();

            if (invoiceToUpdate != null)
            {
                invoiceToUpdate.Updated = DateTime.Now;
                invoiceToUpdate.ContractorName = invoice.ContractorName;
                invoiceToUpdate.ContractorEmail = invoice.ContractorEmail;
                invoiceToUpdate.ContractorPhoneNumber = invoice.ContractorPhoneNumber;
                invoiceToUpdate.ContractorOrder = invoice.ContractorOrder;
                invoiceToUpdate.VatPayer = invoice.VatPayer;
                invoiceToUpdate.BankAccountNumber = invoice.BankAccountNumber;
                invoiceToUpdate.Address = invoice.Address;
                invoiceToUpdate.Period = invoice.Period;
                invoiceToUpdate.PaymentDeadline = invoice.PaymentDeadline;
                invoiceToUpdate.Сurrency= invoice.Сurrency;
                invoiceToUpdate.InvoiceState = invoice.InvoiceState;
                invoiceToUpdate.HoursCount = invoice.HoursCount;
                invoiceToUpdate.HourRate = invoice.HourRate;
                invoiceToUpdate.TaxRate = invoice.TaxRate;
                invoiceToUpdate.Expenses = invoice.Expenses;
                invoiceToUpdate.ExpensesAmount = invoice.ExpensesAmountCount();
                invoiceToUpdate.Amount = invoice.AmountCount();
                invoiceToUpdate.VATAmount = invoice.VATAmountCount();



                await _context.SaveChangesAsync();

                return invoice;
            }

            return null;
        }
    }
}
