using CO_CI.Models;

namespace CO_CI.Services
{
    public interface IInvoiceService
    {
        Task<Invoice[]> GetAllInvoices();
        Task<Invoice> GetInvoiceById(int invoiceId);
        Task<Invoice> CreateInvoice(Invoice invoice);
        Task<Invoice> UpdateInvoice(Invoice invoice);
        Task<bool> DeleteInvoice(int invoiceId);
    }
}
