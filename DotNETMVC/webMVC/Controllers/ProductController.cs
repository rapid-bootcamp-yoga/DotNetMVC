using Microsoft.AspNetCore.Mvc;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult List()
        {
            List<ProductViewModel> productList = new List<ProductViewModel>()
            {
                new ProductViewModel(1, "Pepaya", "Buah", 12000),
                new ProductViewModel(2, "Nasi Liwet", "Makanan", 15000),
                new ProductViewModel(3, "Jus Melon", "Minuman", 14000),
                new ProductViewModel(4, "Ikan Gurame", "Makanan", 56000),
            };
                return View(productList);
        }

        public IActionResult Detail()
        {
            ProductViewModel product = new ProductViewModel(1, "Nasi Telor", "Makanan", 43000);
            return View(product);
;        }
    }
}
