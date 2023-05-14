namespace Employee.Models.Domain
{
    public class Employee
    {

        public Guid EmpId { get; set; }
        public string EmpName { get; set; }

        public string Email { get; set; }
        public long Mobile { get; set; }
    }
}
