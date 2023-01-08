using Microsoft.AspNetCore.Mvc;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<EmployeeViewModel> _employeeViewModels = new List<EmployeeViewModel>()
        {
            new EmployeeViewModel(1, "Jihan", "user1@gmail.com", "Marketing"),
            new EmployeeViewModel(2, "fulan", "user2@gmail.com", "HRD"),
            new EmployeeViewModel(3, "Yoga", "user3@gmail.com", "Developer"),
        };

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Save([Bind("Id", "EmployeeName", "Email", "Position")] EmployeeViewModel model)
        {
            _employeeViewModels.Add(model);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_employeeViewModels);
        }
        
        public IActionResult Details(int id)
        {
            EmployeeViewModel employee = (
                 from p in _employeeViewModels
                 where p.Id.Equals(id)
                 select p
                 ).SingleOrDefault(new EmployeeViewModel());
            return View(employee);
        }

        public IActionResult Edit(int? id)
        {
            EmployeeViewModel employee = _employeeViewModels.Find(x => x.Id.Equals(id));
            return View(employee);
        }

        public IActionResult Update(int id, [Bind("Id", "EmployeeName", "Email", "Position")] EmployeeViewModel employee)
        {
            EmployeeViewModel employeeBefore = _employeeViewModels.Find(x => x.Id.Equals(id));
            _employeeViewModels.Remove(employeeBefore);

            _employeeViewModels.Add(employee);
            return Redirect("List");
        }

        public IActionResult Delete(int? id) 
        {
            EmployeeViewModel employee = _employeeViewModels.Find(x => x.Id.Equals(id));
            _employeeViewModels.Remove(employee);
            return Redirect("List");
        }
    }
}
