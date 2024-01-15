using SafeWorks.AccesoDatos.Data.Repository.IRepository;
using SafeWorks.Models;
using SafeWorksWEB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SafeWorks.AccesoDatos.Data.Repository
{
    internal class EmpleadosRepository : Repository<Empleado>, IEmpleadosRepository
    {
        private readonly ApplicationDbContext _db;

        public EmpleadosRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaEmpleados()
        {
            return _db.Empleado.Select(i => new SelectListItem()
            {
                Text = i.nombre,
                Value = i.id.ToString()
            }
            );
        }

        public void Update(Empleado empleado)
        {
            var objDesdeDb = _db.Empleado.FirstOrDefault(s => s.id == empleado.id);
            objDesdeDb.nombre = empleado.nombre;
            objDesdeDb.apellido_p = empleado.apellido_p;
            objDesdeDb.apellido_m = empleado.apellido_m;
            objDesdeDb.mail = empleado.mail;
            objDesdeDb.celular = empleado.celular;
            objDesdeDb.contraseña = empleado.contraseña;
            objDesdeDb.Apodo = empleado.Apodo;
            objDesdeDb.fecha_contrato = empleado.fecha_contrato;
            objDesdeDb.fecha_pago = empleado.fecha_pago;

            //_db.SaveChanges();
        }

       
    }
}
