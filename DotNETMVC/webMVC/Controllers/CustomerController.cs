using Microsoft.AspNetCore.Mvc;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class CustomerController : Controller
    {
        private static List<CustomerViewModel> _customerViewModels = new List<CustomerViewModel>()
        {
            new CustomerViewModel(1, "Tiyo", "cus1@gmail.com", "password1"),
            new CustomerViewModel(2, "Tiyo", "cus2@gmail.com", "password2"),
            new CustomerViewModel(3, "Tiyo", "cus3@gmail.com", "password3"),
        };

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Save([Bind("Id", "Name", "Email", "Password")] CustomerViewModel model)
    }
}
