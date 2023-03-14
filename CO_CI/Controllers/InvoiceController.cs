using CO_CI.Models;
using CO_CI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CO_CI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<Invoice[]> GetAllInvoices()
        {
            try
            {
                return await _invoiceService.GetAllInvoices();
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return new Invoice[] { };
            }
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<Invoice> GetInvoiceById(int id)
        {
            try
            {
                return await _invoiceService.GetInvoiceById(id);
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return new Invoice { };
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice invoice)
        {
            try
            {
                return Ok(await _invoiceService.CreateInvoice(invoice));
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return null;
            }
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateInvoice([FromBody] Invoice invoice)
        {
            try
            {
                return Ok(await _invoiceService.UpdateInvoice(invoice));
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return null;
            }
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            try
            {
                if (await _invoiceService.DeleteInvoice(id) == true)
                {
                    return new OkResult();
                }
                else
                {
                    return new BadRequestResult();
                }
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                return null;
            }
        }
    }
}
