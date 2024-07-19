using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Employee_ManagementSystem.Models
{
    public class Supervisor
    {

        [Key]
        public int Id { get; set; }

        [DisplayName("Supervisor's Name")]
        public string? Name { get; set; }

        [DisplayName("Supervisor's Jobtitle")]
        public string? SupervisorTitle { get; set; }
    }
}
