using Microsoft.EntityFrameworkCore;
using Employee.Models.Domain;
namespace Employee.Data
{
    public class EmpDBContextL : DbContext
    {
        protected EmpDBContextL(DbContextOptions options):base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
