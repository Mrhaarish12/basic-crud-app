﻿using FirstProject.Data;
using FirstProject.Models;
using FirstProject.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDemoDbContext mVCDemoDbContext;
        public EmployeesController(MVCDemoDbContext mVCDemoDbContext)
        {
            this.mVCDemoDbContext = mVCDemoDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddEmployeeViewModelcs addEmployeeRequest)
        {
            var employee = new EmployeeModel()
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
