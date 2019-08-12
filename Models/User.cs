using System.ComponentModel.DataAnnotations;

namespace Form_Submission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "Your First Name:")]
        public string _fname {get; set;}

        [MinLength(4)]
        [Required]
        [Display(Name = "Your Last Name:")]
        public string _lname {get; set;} 

        [Required]
        [Range(13, 150)]
        [Display(Name = "Your Age:")]
        public int _age {get; set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Your Email Address:")]
        public string _email {get; set;} 

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Your Password:")]
        public string _password {get; set;} 
    }
}
