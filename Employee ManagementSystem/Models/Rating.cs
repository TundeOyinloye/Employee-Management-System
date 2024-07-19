using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Employee_ManagementSystem.Models
{
    public class Rating
    {

        [Key]
        public int Id { get; set; }

        [DisplayName("Rating Type")]
        public string RatingType { get; set; }

     }
}
