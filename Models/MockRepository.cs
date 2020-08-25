using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreApp.Models
{
    public class MockRepository : IRepository
    {
        private List<Employee> _employees;
        public MockRepository()
        {
            if (_employees == null)
            {
                InitializeRepository();
            }
        }
        private void InitializeRepository()
        {
            _employees = new List<Employee>
            {
                    new Employee { ID=1, Name="Dhiraj",Salary=10000 },
                    new Employee { ID=2, Name="Suraj", Salary=12000 },
                    new Employee { ID=3, Name="Niraj", Salary=13000 },
                    new Employee { ID=4, Name="Biraj", Salary=12500 },                
             };
        }        
        public Employee GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(x => x.ID == id);
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }
    }
}
