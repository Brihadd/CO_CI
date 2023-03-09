using Microsoft.AspNetCore.Mvc;

namespace CO_CI.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
