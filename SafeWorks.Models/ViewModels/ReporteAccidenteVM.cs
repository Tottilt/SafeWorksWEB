using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SafeWorks.Models.ViewModels
{
    public class ReportarAccidente
    {

        public Models.ReportarAccidente ReporteAccidente { get; set; }

        public IEnumerable<SelectListItem> ListaReportarAccidente { get; set; }
    }
}
