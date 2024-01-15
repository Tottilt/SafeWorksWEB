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
    internal class WorkerLocationRepository : Repository<WorkerLocationDto>, IWorkerLocationRepository
    {
        private readonly ApplicationDbContext _db;

        public WorkerLocationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;        
        }
        public IEnumerable<SelectListItem> ListaWorkerLocation()
        {
            return _db.WorkerLocationDto.Select(i => new SelectListItem()
                {
                    Text = i.WorkerName,
                    Value = i.Id.ToString()
                }
            ); 
        }

        public void Update(WorkerLocationDto workerLocationDto)
        {
            var objDesdeDb = _db.WorkerLocationDto.FirstOrDefault(s => s.Id == workerLocationDto.Id);
            objDesdeDb.WorkerName = workerLocationDto.WorkerName;
            objDesdeDb.Latitude = workerLocationDto.Latitude;
            objDesdeDb.Longitude = workerLocationDto.Longitude;

            //_db.SaveChanges();
        }
    }
}
