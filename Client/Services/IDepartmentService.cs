using EmployeeManagement.Shared;

namespace EmployeeManagement.Client.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
        Task<Department> AddDepartment(Department department);
        Task<Department> UpdateDepartment(Department department);
        Task DeleteDepartment(int departmentId);
    }
}
