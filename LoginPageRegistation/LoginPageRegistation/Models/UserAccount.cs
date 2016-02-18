using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoginPageRegistation.Models
{
    class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage ="FirstName is required.")]
        public string FristName { get; set; }

        [Required(ErrorMessage ="LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage ="User Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Please confirm your password.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
