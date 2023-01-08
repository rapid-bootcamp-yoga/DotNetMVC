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

       

        public IActionResult Edit(int? id)
        {
            //cari data dulu pakai lamda  =>
            ProductViewModel product = _productViewModels.Find(x => x.Id.Equals(id));
            return View(product);
        }

        public IActionResult Update(int id, [Bind("Id, Name, Category, Price")] ProductViewModel product)
        {
            //hapus data sebelumnya by ID dulu 
            ProductViewModel productBefore = _productViewModels.Find(x => x.Id.Equals(id));
            _productViewModels.Remove(productBefore);

            //input data baru yang mau diberikan
            _productViewModels.Add(product);
            return Redirect("List");
        }

        public IActionResult Detail(int id)
        {
            //cari dengan linq
            ProductViewModel product = (
                from p in _productViewModels
                where p.Id.Equals(id)
                select p
                ).SingleOrDefault(new ProductViewModel());
            return View(product);
;        }

        public IActionResult Delete(int? id)
        {
            //cari data dulu
            ProductViewModel product = _productViewModels.Find(x => x.Id.Equals(id));

            //baru dihapus
            _productViewModels.Remove(product);

            return Redirect("List");
        }
    }
}
