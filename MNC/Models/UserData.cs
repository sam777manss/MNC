using System.ComponentModel.DataAnnotations;

namespace MNC.Models
{
    public class UserData
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Enter Full Name")]
        public string Fname { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter Last Name")]
        public string Lname { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "The Email Address Is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Phone Number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public int? Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Pincode { get; set; }
    }
}
