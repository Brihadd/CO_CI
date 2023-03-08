using CO_CI.Models;
using Microsoft.EntityFrameworkCore;

namespace CO_CI.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            employee.Created = DateTime.Now;
            employee.Updated = DateTime.Now;
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        public async Task<bool> DeleteEmployee(int employeeId)
        {
           var employeeToDelete = await _context.Employees.
                Where(x => x.Id == employeeId).FirstOrDefaultAsync();
            if (employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

        public async Task<Employee[]> GetAllEmployees()
        {
            return await _context.Employees.ToArrayAsync();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _context.Employees.Where(x => x.Id == employeeId).FirstAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var employeeToUpdate = await _context.Employees.
                Where(x => x.Id == employee.Id).FirstOrDefaultAsync();

            if (employeeToUpdate!= null)
            {
                employeeToUpdate.Updated= DateTime.Now;
                employeeToUpdate.Name = employee.Name;
                employeeToUpdate.Surname = employee.Surname;
                employeeToUpdate.PhoneNumber = employee.PhoneNumber;
                employeeToUpdate.UserStatus = employee.UserStatus;
                employeeToUpdate.UserStatus = employee.UserStatus;
                employeeToUpdate.UserStatus = employee.UserStatus;

                await _context.SaveChangesAsync();

                return employee;
            }

            return null;
        }
    }
}
