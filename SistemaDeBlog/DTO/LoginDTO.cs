using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeBlog.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="Este campo es requerido")]
        [Display(Name ="Nombre de Usuario")]
        public string UserName { get; set; }

        [Display(Name = "Contrasena")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
