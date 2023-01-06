using Microsoft.AspNetCore.Mvc;

namespace webMVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
