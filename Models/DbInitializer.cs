using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public static class DbInitializer
    {
        public static void Seed(DatabaseContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            if (!dbContext.Employees.Any())
            {
                var employees=new Employee[]
                {
                    new Employee { ID = 1, Name = "Dhiraj", Salary = 10000 },
                    new Employee { ID = 2, Name = "Suraj", Salary = 12000 },
                    new Employee { ID = 3, Name = "Niraj", Salary = 13000 },
                    new Employee { ID = 4, Name = "Biraj", Salary = 12500 }
                };
                foreach(Employee emp in employees)
                {
                    dbContext.Employees.Add(emp);
                }
            }
            dbContext.SaveChanges();
        }
    }
}
