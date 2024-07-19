using System.ComponentModel.DataAnnotations;

namespace Employee_ManagementSystem.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public  string CountryCode { get; set; }

        public  string CountryName { get; set; }
    }
}
