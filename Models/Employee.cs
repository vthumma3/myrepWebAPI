﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
