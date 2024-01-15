using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SafeWorks.Models.ViewModels
{
    public class AsesoriaVM
    {
        public Models.Asesoria Asesoria { get; set; }

        public IEnumerable<SelectListItem> ListaEmpleados { get; set; }
    }
}
