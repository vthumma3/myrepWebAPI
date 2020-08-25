using System;
using System.Collections.Generic;
using CoreApp.Models;

namespace CoreApp.ViewModels
{
    public class EmployeeViewModel
    {
        public string Title { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
