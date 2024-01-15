using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeWorks.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        IActividadesRepository Actividades { get; }
        ICapacitacionRepository Capacitacion { get; }

        IUsuarioRepository Usuario { get; }
        IReportarAccidenteRepository ReportarAccidente { get; }

        IAsesoriaEspecialRepository AsesoriaEspecial { get; }

        IAsesoriaRepository Asesoria{ get; }

        IEmpleadosRepository Empleado { get; }
        IWorkerLocationRepository WorkerLocationDto { get; }
        void Save();
    }
}
