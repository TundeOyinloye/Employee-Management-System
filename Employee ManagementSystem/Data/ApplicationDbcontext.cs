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
        public DbSet<Bio> BioData { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Leave> Leaves { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<Supervisor> Supervisors { get; set; }
    }
}
