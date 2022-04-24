using EmployeeManagement.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EmployeeManagement.Client.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Department>>("api/departments");
        }

        public Task<Department> AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDepartment(int departmentId)
        {
            throw new NotImplementedException();
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            return await httpClient.GetFromJsonAsync<Department>($"api/departments/{departmentId}");
        }

        public Task<Department> UpdateDepartment(Department Department)
        {
            throw new NotImplementedException();
        }
    }
}
