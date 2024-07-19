using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Employee_ManagementSystem.Models
{
    public class Bio
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Employee Name")]
        public int EmployeeId { get; set; }
        public required Employee Employee { get; set; }

        [DisplayName("Date of Birth")]
        public required DateOnly DateOfBirth { get; set; }

        [DisplayName("Local Government Area")]
        public required string LGA { get; set; }

        [DisplayName("Name of Next of Kin")]
        public string NextOfKin { get; set; }

        [DisplayName("State of Origin")]
        public string StateOfOrigin { get; set; }

        [DisplayName("Date of Resumption")]
        public required DateOnly DateOfResumption { get; set; }

        [DisplayName("Social Media Links")]
        public string SocialHandles { get; set; }

        // 
        //[DisplayName("Upload CV")]
        //public file File { get; set; }

        public string Remarks { get; set; }
    }
}
