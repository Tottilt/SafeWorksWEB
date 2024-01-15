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
    internal class ReportarAccidenteRepository : Repository<ReportarAccidente>, IReportarAccidenteRepository
    {
        private readonly ApplicationDbContext _db;

        public ReportarAccidenteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;        
        }
        public IEnumerable<SelectListItem> ListaReportarAccidente()
        {
            return _db.ReportarAccidente.Select(i => new SelectListItem()
                {
                    Text = i.nombres,
                    Value = i.Id.ToString()
                }
            ); 
        }

        public void Update(ReportarAccidente reportaraccidente)
        {
            var objDesdeDb = _db.ReportarAccidente.FirstOrDefault(s => s.Id == reportaraccidente.Id);
            objDesdeDb.nombres = reportaraccidente.nombres;
            objDesdeDb.apellidos = reportaraccidente.apellidos;
            objDesdeDb.mail = reportaraccidente.mail;
            objDesdeDb.celular = reportaraccidente.celular;
            objDesdeDb.descripcion = reportaraccidente.descripcion;
            objDesdeDb.UrlImagen = reportaraccidente.UrlImagen;

            //_db.SaveChanges();
        }
    }
}
