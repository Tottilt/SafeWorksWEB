using SafeWorks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SafeWorks.AccesoDatos.Data.Repository.IRepository
{
    public interface IEmpleadosRepository : IRepository<Empleado>
    {
        IEnumerable<SelectListItem> GetListaEmpleados();

        void Update(Empleado empleado);
    }
}
