using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeWorks.Models
{
    public class Actividades
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ingrese un nombre para la actividad")]
        [Display(Name ="Nombre Actividad")]
        public string Nombre { get; set; }
        [Display(Name = "Orden de visualización")]

        public int? Orden { get; set; }
        [Required(ErrorMessage ="Ingrese un valor para la actividad")]
        [Display(Name = "Valor Actividad")]

        public int Valor { get; set; }
    }
}
