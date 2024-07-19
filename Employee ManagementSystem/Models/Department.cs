using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Employee_ManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Department Name")]
        public  string DeparmentName { get; set; }

        [DisplayName("Department HOD")]
        public string DeparmentHod { get; set; }
    }
}
