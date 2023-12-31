using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class EmployeesController : Controller
    {
        public EmployeesController()
        {

        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddEmployeeViewModelcs addEmployeeRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                Department = addEmployeeRequest.Department,
                DateOfBirth = addEmployeeRequest.DateOfBirth,
            };
            return View(employee);
        }
    }
}
