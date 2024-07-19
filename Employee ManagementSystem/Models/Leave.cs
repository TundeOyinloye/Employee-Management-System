using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Employee_ManagementSystem.Models
{
    public class Leave
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Leave Status")]
        public string LeaveStatus { get; set; }

    }
}
