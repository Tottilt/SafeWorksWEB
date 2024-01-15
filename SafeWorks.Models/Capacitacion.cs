using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeWorks.Models
{
    public class Capacitacion
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre para la capacitacion")]
        [Display(Name = "Nombre Capacitación")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese una descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Cantidad de asistentes")]
        public int? CantidadAsist { get; set; }
        [Required(ErrorMessage = "Ingrese los materiales a utilizar")]
        [Display(Name = "Materiales a utilizar")]
        public string MaterialesAUtilizar { get; set; }

    }
}
