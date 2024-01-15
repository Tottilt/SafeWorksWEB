using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeWorks.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido paterno es obligatorio")]
        public string Apellido_p { get; set; }

        [Required(ErrorMessage = "El apellido materno es obligatorio")]
        public string Apellido_m { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        public string correo { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        public string celular { get; set; }

        public string apodo { get; set; }
    }
}
