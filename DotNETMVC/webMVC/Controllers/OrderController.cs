using Microsoft.AspNetCore.Mvc;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class OrderController : Controller
    {
        private static List<OrderViewModel> orderViewModels = new List<OrderViewModel>()
       {
           new OrderViewModel(1, 20, "Pilih yang bagus"),
           new OrderViewModel(1, 20, "Pilih yang bagus"),
           new OrderViewModel(1, 20, "Pilih yang bagus"),
       };
    }
}
