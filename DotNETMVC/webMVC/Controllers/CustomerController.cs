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
        {
            _customerViewModels.Add(model);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_customerViewModels);
        }

        public IActionResult Details(int id)
        {
            CustomerViewModel customer = (
                from p in _customerViewModels
                where p.Id.Equals(id)
                select p
                ).SingleOrDefault(new CustomerViewModel());
            return View(customer);
        }

        public IActionResult Edit(int? id)
        {
            CustomerViewModel customer = _customerViewModels.Find(x => x.Id.Equals(id));
            return View(customer);
        }

        public IActionResult Update(int id, [Bind("Id", "Name", "Email", "Password")] CustomerViewModel customer)
        {
            CustomerViewModel customerBefore = _customerViewModels.Find(x => x.Id.Equals(id));
            _customerViewModels.Remove(customerBefore);

            _customerViewModels.Add(customer);
            return Redirect("List");
        }

        public IActionResult Delete(int? id)
        {
           CustomerViewModel customer = _customerViewModels.Find(x => x.Id.Equals(id));
            _customerViewModels.Remove(customer);
            return Redirect("List");
        }
    }
}
