using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeWorks.Models
{
    public class Empleado
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorios")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string apellido_p { get; set; }
        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string apellido_m { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        public string mail { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        public int celular { get; set; }

        public double? Latitud { get; set; }
        public double? Longitud { get; set; }

        public string? contraseña { get; set; } = "";
        public string? Apodo { get; set; } = "";
        public string? fecha_contrato { get; set; } = "";
        public string? fecha_pago { get; set; } = "";

    }
}
