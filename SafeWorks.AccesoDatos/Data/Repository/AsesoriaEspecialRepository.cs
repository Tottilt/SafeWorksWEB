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
    internal class AsesoriaEspecialRepository : Repository<AsesoriaEspecial>, IAsesoriaEspecialRepository
    {
        private readonly ApplicationDbContext _db;

        public AsesoriaEspecialRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;        
        }

        public void Update(AsesoriaEspecial asesoriaespecial)
        {
            var objDesdeDb = _db.AsesoriaEspecial.FirstOrDefault(s => s.id == asesoriaespecial.id);
            objDesdeDb.nombres = asesoriaespecial.nombres;
            objDesdeDb.apellidos = asesoriaespecial.apellidos;
            objDesdeDb.mail = asesoriaespecial.mail;
            objDesdeDb.celular = asesoriaespecial.celular;
            objDesdeDb.descripcion = asesoriaespecial.descripcion;
            objDesdeDb.empleado_id = asesoriaespecial.empleado_id;

            _db.SaveChanges();
        }
    }
}
