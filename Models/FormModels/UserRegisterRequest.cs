using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models.FormModels
{
    public class UserRegisterRequest
    {
   
        [Required, Display(Name = "User Name", Prompt = "Enter User Name ...")]
        public string UserName { get; set; }

       [Required, Display(Name = "User Email", Prompt = "Enter User Email ...")]
        public string Email { get; set; }

        [Required, Display(Name = "User Role", Prompt = "Enter User Role ...")]
        public string   Role { get; set; }

        [Required, Display(Name=" Password", Prompt = "Enter User Password...")]
        [MinLength(6),DataType(DataType.Password)]
        public string Password { get; set; }

         [Required, Display(Name = " Confirm Password", Prompt = "Enter Confirm Password ...")]
        [MinLength(6), DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string  ConfirmPassword { get; set; }

    }
}
