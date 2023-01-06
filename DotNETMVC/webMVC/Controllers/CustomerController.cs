using Microsoft.AspNetCore.Mvc;

namespace webMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
