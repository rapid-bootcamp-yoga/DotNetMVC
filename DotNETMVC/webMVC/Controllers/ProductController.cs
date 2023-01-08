using Microsoft.AspNetCore.Mvc;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class ProductController : Controller
    {
        private static List<ProductViewModel> _productViewModels = new List<ProductViewModel>()
        {
            new ProductViewModel(1, "Pepaya", "Buah", 12000),
                new ProductViewModel(2, "Nasi Liwet", "Makanan", 15000),
                new ProductViewModel(3, "Jus Melon", "Minuman", 14000),
                new ProductViewModel(4, "Ikan Gurame", "Makanan", 56000),
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Save([Bind("Id, Name, Category, Price")] ProductViewModel model)
        {
            _productViewModels.Add(model);
            return Redirect("List");
        }

        public IActionResult List()
        {
                return View(_productViewModels);
        }

        public IActionResult Detail()
        {
            ProductViewModel product = new ProductViewModel(1, "Nasi Telor", "Makanan", 43000);
            return View(product);
;        }
    }
}
