using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CO_CI.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
