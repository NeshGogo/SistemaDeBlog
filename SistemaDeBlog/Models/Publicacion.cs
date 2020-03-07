using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeBlog.Models
{
    public class Publicacion
    {
        public int PublicacionId { get; set; }
        public DateTime RegisterDate { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        [Display(Name ="Titulo")]
        [StringLength(50, ErrorMessage ="El maximo de caracteres permitidos para este campo es de 50")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [Display(Name = "Contenido")]
        public string Content { get; set; }

        public string UserId { get; set; }
    }
}
