using Microsoft.AspNetCore.Mvc;

namespace CO_CI.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
