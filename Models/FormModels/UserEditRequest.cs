using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models.FormModels
{
    public class UserEditRequest
    {
        public int UserId { get; set; }

        [Required, Display(Name = "User Name", Prompt = "Enter User Name ...")]
        public string UserName { get; set; }

        [Required, Display(Name = "User Email", Prompt = "Enter User Email ...")]
        [EmailAddress]
        public string Email { get; set; }

     

       
    }
}
