using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taruma.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Input {0} is required!")]
        [StringLength(40, ErrorMessage = "Value of caracteres invalid!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Input {0} is required!")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Input {0} is required!")]
        public string Phone { get; set; }

        public string Photo { get; set; }

        [Required(ErrorMessage = "Input {0} is required!")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [EmailAddress(ErrorMessage = "Email invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Input {0} is required!")]
        [StringLength(40, ErrorMessage = "Use few characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Input {0} is required!")]
        [StringLength(40, ErrorMessage = "Use few characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password confirm")]
        [Compare("Password", ErrorMessage = "The password not confirm")]
        public string PasswordConfirmed { get; set; }
    }
}
