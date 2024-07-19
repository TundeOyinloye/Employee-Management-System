using Employee_ManagementSystem.Data;
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

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        [DisplayName("Email Address")]
        [EmailAddress]
        public required string EmailAddress { get; set; }

        [DisplayName("Phone #")]
        //put the phone number range
        public required string PhoneNo { get; set; }

        [DisplayName("Residential Address")]
        public string ResidentialAddress { get; set; }

        
        //relationship with country

        [DisplayName("Country")]
        public int CountryId { get; set; }
        public  Country? Country { get; set; }

        //relationship with job

        [DisplayName("JobTitle")]
        public int JobId { get; set; }
        public  Job? Job { get; set; }

        //relationship with department

        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        public  Department?  Deparment { get; set; }

        //relationship with supervisor

        [DisplayName("Supervisor")]
        public int SupervisorId { get; set; }
        public  Supervisor? Supervisor { get; set; }

        //relationship with rating

        [DisplayName("Employee Rating")]
        public int RatingId { get; set; }
        public  Rating? Rating { get; set; }

        //relationship with state

        [DisplayName("State")]
        public int StateId { get; set; }
        public  State? State { get; set; }

        //relationship with leave

        [DisplayName("Leave Status")]
        public int LeaveId { get; set; }
        public  Leave? Leave { get; set; }




        // add other related colomns
        //add this to the bio model
        //[DisplayName("Resumption Date")]
        //public DateTime? DateOfResumption { get; set; }
    }
}
