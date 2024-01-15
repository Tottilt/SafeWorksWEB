using SafeWorks.AccesoDatos.Data.Repository.IRepository;
using SafeWorks.Models;
using SafeWorksWEB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SafeWorks.AccesoDatos.Data.Repository
{
    internal class CapacitacionRepository : Repository<Capacitacion>, ICapacitacionRepository
    {
        private readonly ApplicationDbContext _db;

        public CapacitacionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Capacitacion capacitacion)
        {
            var objDesdeDb = _db.Capacitacion.FirstOrDefault(s => s.Id == capacitacion.Id);
            objDesdeDb.Nombre = capacitacion.Nombre;
            objDesdeDb.Descripcion = capacitacion.Descripcion;
            objDesdeDb.CantidadAsist = capacitacion.CantidadAsist;
            objDesdeDb.MaterialesAUtilizar = capacitacion.MaterialesAUtilizar;

            //_db.SaveChanges();
        }
    }
}