using System;

namespace CO_CI.Models
{
    public class Contractor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Deleted { get; set; }
    }
}
