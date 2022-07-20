﻿using ModelLayer.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IEmployeeRL
    {
        public void AddEmployee(EmployeeModel employee);
        public IEnumerable<EmployeeModel> GetAllEmployees();
        public EmployeeModel GetEmployeeData(int? id);
        public void UpdateEmployee(EmployeeModel employee);
        public void DeleteEmployee(int? id);
    }
}