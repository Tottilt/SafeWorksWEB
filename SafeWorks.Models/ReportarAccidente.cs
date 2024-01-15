using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeWorks.Models
{
    public class ReportarAccidente 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Los nombres son obligatorios")]
        public string nombres { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        public string mail { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        public string celular { get; set; }
            
        public string descripcion { get; set; }

        [Display(Name = "Fecha")]
        public string fecha { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }
    }
}
