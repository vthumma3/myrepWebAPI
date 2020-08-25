using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class Repository : IRepository
    {
        private readonly DatabaseContext _dbContext;
        public Repository(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }

        public Employee GetEmployeeById(int id)
        {
            return _dbContext.Employees.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _dbContext.Employees;
        }
    }
}
