using Employee_ManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_ManagementSystem.Data
{
    public class ApplicationDbcontext: DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options): base(options)
        {
            
        }

        // create the db tables using Dbset
        public DbSet<Employee> Employees { get; set; }
    }
}
