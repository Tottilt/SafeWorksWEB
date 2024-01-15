using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SafeWorks.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Actividades> ListaActividades { get; set; }
        public IEnumerable<Capacitacion> ListaCapacitacion { get; set; }
    }
}
