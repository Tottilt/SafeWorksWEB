using SafeWorks.AccesoDatos.Data.Repository.IRepository;
using SafeWorks.Models;
using SafeWorksWEB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeWorks.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Actividades = new ActividadesRepository(_db);
            Capacitacion = new CapacitacionRepository(_db);
            Usuario = new UsuarioRepository(_db);
            ReportarAccidente = new ReportarAccidenteRepository(_db);
            AsesoriaEspecial = new AsesoriaEspecialRepository(_db);
            Asesoria = new AsesoriaRepository(_db);
            Empleado = new EmpleadosRepository(_db);
            WorkerLocationDto = new WorkerLocationRepository(_db);
        }

        public IActividadesRepository Actividades { get; private set; }
        public ICapacitacionRepository Capacitacion { get; private set; }
        public IUsuarioRepository Usuario { get; private set; }
        public IReportarAccidenteRepository ReportarAccidente { get; private set; }
        public IAsesoriaEspecialRepository AsesoriaEspecial { get; private set; }
        public IAsesoriaRepository Asesoria { get; private set; }
        public IEmpleadosRepository Empleado { get; private set; }
        public IWorkerLocationRepository WorkerLocationDto { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
