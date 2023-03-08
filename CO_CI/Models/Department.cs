namespace CO_CI.Models
{
    public class Department:Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ManagerId { get; set; }

    } 
}
