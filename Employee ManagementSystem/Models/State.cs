using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Employee_ManagementSystem.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("State")]
        public string StateName { get; set; }
 
    }
}
