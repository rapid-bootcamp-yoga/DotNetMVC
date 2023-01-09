using Microsoft.AspNetCore.Mvc;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class OrderController : Controller
    {
        private static List<OrderViewModel> _orderViewModels = new List<OrderViewModel>()
       {
           new OrderViewModel(1, 20, "Pilih yang bagus", 1),
           new OrderViewModel(2, 20, "Pilih yang bagus", 2),
           new OrderViewModel(3, 20, "Pilih yang bagus",  3),
       };

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Save([Bind("Id", "Count", "Description", "ProductId" )] OrderViewModel model)
        {
            _orderViewModels.Add(model);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_orderViewModels);
        }

        public IActionResult Details(int id)
        {
            OrderViewModel order = (
                from p in _orderViewModels
                where p.Id.Equals(id)
                select p
                ).SingleOrDefault(new OrderViewModel());
            return View(order);
        }

        public IActionResult Edit(int? id)
        {
            OrderViewModel order = _orderViewModels.Find(x => x.Id.Equals(id));
            return View(order);
        }

        public IActionResult Update(int id, [Bind("Id", "Count", "Description", "ProductId")] OrderViewModel order)
        {
            OrderViewModel orderBefore = _orderViewModels.Find(x => x.Id.Equals(id));
            _orderViewModels.Remove(orderBefore);

            _orderViewModels.Add(order);
            return Redirect("List");
        }

        public IActionResult Delete(int? id) 
        {
            OrderViewModel order = _orderViewModels.Find(x => x.Id.Equals(id));
            _orderViewModels.Remove(order);
            return Redirect("List");
        }

    }
}
