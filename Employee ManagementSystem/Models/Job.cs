using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Employee_ManagementSystem.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Job Title")]
        public  string JobTitle { get; set; }

        [DisplayName("Job Type")]
        public  string JobType { get; set; }
    }
}
