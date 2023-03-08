using CO_CI.Models;
using Microsoft.EntityFrameworkCore;

namespace CO_CI.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DataContext _context;

        public DepartmentService(DataContext context)
        {
            _context = context;
        }
        public async Task<Department> CreateDepartment(Department department)
        {
            department.Created = DateTime.Now;
            department.Updated = DateTime.Now;
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();

            return department;
        }

        public async Task<bool> DeleteDepartment(int departmentId)
        {
            var departmentToDelete = await _context.Departments.
                 Where(x => x.Id == departmentId).FirstOrDefaultAsync();
            if (departmentToDelete != null)
            {
                _context.Departments.Remove(departmentToDelete);
                await _context.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

        public async Task<Department[]> GetAllDepartments()
        {
            return await _context.Departments.ToArrayAsync();
        }

        public async Task<Department> GetDepartmentById(int departmentId)
        {
            return await _context.Departments.Where(x => x.Id == departmentId).FirstAsync();
        }

        public async Task<Department> UpdateDepartment(Department department)
        {
            var departmentToUpdate = await _context.Departments.
                Where(x => x.Id == department.Id).FirstOrDefaultAsync();

            if (departmentToUpdate != null)
            {
                departmentToUpdate.Updated = DateTime.Now;
                departmentToUpdate.Name = department.Name;
                departmentToUpdate.ManagerId = department.ManagerId;

                await _context.SaveChangesAsync();

                return department;
            }

            return null;
        }
    }
}
