using Microsoft.AspNetCore.Mvc;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class CompanyController : Controller
    {
        private static List<CompanyViewModel> _companyViewModels = new List<CompanyViewModel>()
        {
            new CompanyViewModel( 1, "Astra", "Otomotif", "Jl Sudirman"),
            new CompanyViewModel( 2, "Telkomsel", "Komunikasi Informasi", "Jakarta"),
             new CompanyViewModel( 3, "Yamaha", "Otomotif", "Jakarta"),
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Save([Bind("Id", "CompanyName", "Segmentasi", "Address")] CompanyViewModel model)
        {
            _companyViewModels.Add(model);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_companyViewModels);
        }

        public IActionResult Details(int id)
        {
            CompanyViewModel company = (
                from p in _companyViewModels
                where p.Id.Equals(id)
                select p
                ).SingleOrDefault(new CompanyViewModel());
            return View(company);
        }

        public IActionResult Edit(int? id)
        {
            CompanyViewModel company = _companyViewModels.Find(x => x.Id.Equals(id));
            return View(company);
        }

        public IActionResult Update(int id, [Bind("Id", "CompanyName", "Segmentasi", "Address")] CompanyViewModel company)
        {
            CompanyViewModel companyBefore = _companyViewModels.Find(x => x.Id.Equals(id));
            _companyViewModels.Remove(companyBefore);

            _companyViewModels.Add(company);
            return Redirect("List");
        }

        public IActionResult Delete(int? id) 
        {
            CompanyViewModel company = _companyViewModels.Find(x => x.Id.Equals(id));
            _companyViewModels.Remove(company);
            return Redirect("List");
        }
    }
}
