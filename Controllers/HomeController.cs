using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreApp.Models;
using CoreApp.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoreApp
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            //ViewBag.Title = "My Employees Details";
            var employees = _repository.GetAllEmployees();
            var viewModel = new EmployeeViewModel
            {
                Title = "Displaying Employee Data",
                Employees = employees.ToList()
            };            
            return View(viewModel);
        }
    }
}
