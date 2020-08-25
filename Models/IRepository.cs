using System;
using System.Collections.Generic;

namespace CoreApp.Models
{
    public interface IRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
    }
}
