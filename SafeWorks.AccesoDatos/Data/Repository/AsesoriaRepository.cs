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
    internal class AsesoriaRepository : Repository<Asesoria>, IAsesoriaRepository
    {
        private readonly ApplicationDbContext _db;

        public AsesoriaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;        
        }

        public void Update(Asesoria asesoria)
        {
            var objDesdeDb = _db.Asesoria.FirstOrDefault(s => s.id == asesoria.id);
            objDesdeDb.nombres = asesoria.nombres;
            objDesdeDb.apellidos = asesoria.apellidos;
            objDesdeDb.mail = asesoria.mail;
            objDesdeDb.celular = asesoria.celular;
            objDesdeDb.descripcion = asesoria.descripcion;
            objDesdeDb.empleado_id = asesoria.empleado_id;

            //_db.SaveChanges();
        }
    }
}
