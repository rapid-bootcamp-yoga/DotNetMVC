using Microsoft.AspNetCore.Mvc;

namespace webMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
