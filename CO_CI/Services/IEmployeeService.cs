using CO_CI.Models;

namespace CO_CI.Services
{
    public interface IEmployeeService
    {
        Task<Employee[]> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
        Task<Employee> GetEmployeeByEmail(string employeeEmail);
        Task<Employee> CreateEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(int employeeId);
    }
}
