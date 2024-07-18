using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Employee_ManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [DisplayName("First Name")]
        public required string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public required string MiddleName { get; set; }
        
        [DisplayName("Last Name")]
        public required string LastName { get; set; }

        [DisplayName("Email Address")]
        [EmailAddress]
        public required string EmailAddress { get; set; }

        [DisplayName("Phone #")]
        //put the phone number range
        public required string PhoneNo { get; set; }
        // add other related colomns
        //add this to the bio model
        //[DisplayName("Resumption Date")]
        //public DateTime? DateOfResumption { get; set; }
    }
}
