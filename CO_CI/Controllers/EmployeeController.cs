using Microsoft.AspNetCore.Mvc;

namespace CO_CI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
