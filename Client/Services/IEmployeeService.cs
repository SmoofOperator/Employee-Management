﻿using EmployeeManagement.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Client.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task DeleteEmployee(int employeeId);
    }
}