using System;
using System.ComponentModel.DataAnnotations;

namespace MCV.Models
{
    public class ContactModel
    {
        [Required]
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Correo")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El Mensaje no puede tener")]
        [Display(Name = "Mensaje")]
        public string Message { get; set; }
    }
}