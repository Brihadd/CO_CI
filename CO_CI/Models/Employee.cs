using System;

namespace CO_CI.Models
{
    public  class Employee:Base
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        
        public string PhoneNumber { get; set; }

        public UserStatus UserStatus { get; set; }
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }


    }
    public enum UserStatus
    {
        Accountant,
        BackOffice,
        Contractor,
        Manager
    }
}
