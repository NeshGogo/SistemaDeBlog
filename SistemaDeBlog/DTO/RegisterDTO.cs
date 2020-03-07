using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeBlog.DTO
{
    public class RegisterDTO
    {
        [Display(Name ="Nombre de Usuario")]
        [Required(ErrorMessage ="Este campo es requerido")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage ="Debe introducir una direccion de correo electronico")]
        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Email { get; set; }

        [Display(Name = "Contrasena")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Password { get; set; }


        [Display(Name = "Confirmar Contrasena")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Compare("Password", ErrorMessage ="Las contrasenas no coinciden")]
        public string PasswordConfirm { get; set; }
    }
}
