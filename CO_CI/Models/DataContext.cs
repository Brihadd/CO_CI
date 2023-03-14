using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace CO_CI.Models
{
    public class DataContext : DbContext

    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new { id = 1, Name = "FirstDepartment", ManagerId = 1 },
                new { id = 2, Name = "SecondDepartment", ManagerId = 2 },
                new { id = 3, Name = "ThirdDepartment", ManagerId = 3 });

            modelBuilder.Entity<Employee>().HasData(
                new { id = 1, Name = "Ivan", Surname = "Ivanov", PhoneNumber= "+7 (900) 100-00-01",
                UserStatus= UserStatus.Manager,Email="firstmanager@gmail.com", BirthDate= new DateTime(1990,8,1),Deleted =false},
                new {id = 2, Name = "Maxim",Surname = "Maximov", PhoneNumber = "+7 (900) 100-00-02",UserStatus = UserStatus.Manager,
                 Email = "secondmanager@gmail.com",BirthDate = new DateTime(1990, 8, 2), Deleted = false},
                new { id = 3, Name = "Gleb", Surname = "Glebov", PhoneNumber = "+7 (900) 100-00-03", UserStatus = UserStatus.Manager,
                 Email = "thirdmanager@gmail.com",BirthDate = new DateTime(1990, 8, 3),  Deleted = false},
                new {id = 4,Name = "Grigoriy",Surname = "Grigorov", PhoneNumber = "+7 (900) 100-00-05",UserStatus = UserStatus.Accountant,
                  Email = "accountant@gmail.com",BirthDate = new DateTime(1990, 8, 4),Deleted = false},
                new {id = 5,Name = "Vasiliy",Surname = "Vasiliev",PhoneNumber = "+7 (900) 100-00-06", UserStatus = UserStatus.BackOffice,
                  Email = "backofficet@gmail.com", BirthDate = new DateTime(1990, 8, 5), Deleted = false},
                new {id = 5,Name = "Mihail",Surname = "Mihailov",PhoneNumber = "+7 (900) 100-00-07",UserStatus = UserStatus.Contractor,
                 Email = "contractor@gmail.com",BirthDate = new DateTime(1990, 8, 6), Deleted = false});
        }
       
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
