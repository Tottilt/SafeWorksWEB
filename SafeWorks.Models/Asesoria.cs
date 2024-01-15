using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeWorks.Models
{
    public class Asesoria
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorios")]
        public string nombres { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string apellidos { get; set; }
        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string mail { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        public int celular { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        public string descripcion { get; set; }

        [Display(Name = "Fecha")]
        public string fecha { get; set; }

        [Required]
        public int empleado_id { get; set; }

        [ForeignKey("empleado_id")]
        public Empleado Empleado { get; set; }
    }
}
