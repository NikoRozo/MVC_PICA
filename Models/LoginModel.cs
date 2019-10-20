using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_PICA.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Display(Name = "Contraseña")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int logins { get; set; }
    }
}