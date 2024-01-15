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
    internal class ActividadesRepository : Repository<Actividades>, IActividadesRepository
    {
        private readonly ApplicationDbContext _db;

        public ActividadesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;        
        }
        public IEnumerable<SelectListItem> GetListaActividades()
        {
            return _db.Actividades.Select(i => new SelectListItem()
                {
                    Text = i.Nombre,
                    Value = i.Id.ToString()
                }
            ); 
        }

        public void Update(Actividades actividades)
        {
            var objDesdeDb = _db.Actividades.FirstOrDefault(s => s.Id == actividades.Id);
            objDesdeDb.Nombre = actividades.Nombre;
            objDesdeDb.Orden = actividades.Orden;
            objDesdeDb.Valor = actividades.Valor;

            _db.SaveChanges();
        }
    }
}
