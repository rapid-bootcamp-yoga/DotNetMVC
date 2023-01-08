using Microsoft.AspNetCore.Mvc;

namespace webMVC.Controllers
{
    public class PresensiController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
