using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddEmployeeViewModelcs addEmployeeRequest)
        {
            return View();
        }
    }
}
