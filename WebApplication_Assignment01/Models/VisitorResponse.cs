using System.ComponentModel.DataAnnotations;

namespace WebApplication_Assignment01.Models
{
    public class VisitorResponse
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your Designation")]

        public string Designation { get; set; }
        [Required(ErrorMessage = "Please select your Gender")]

        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your age")]

        public string Age { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = ("please enter a valid email address"))]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }



    }
}
