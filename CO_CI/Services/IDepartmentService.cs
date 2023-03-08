using CO_CI.Models;

namespace CO_CI.Services
{
    public interface IDepartmentService
    {
        Task<Department[]> GetAllDepartments();
        Task<Department> GetDepartmentById(int departmentId);
        Task<Department> CreateDepartment(Department department);
        Task<Department> UpdateDepartment(Department department);
        Task<bool> DeleteDepartment(int departmentId);
    }
}
