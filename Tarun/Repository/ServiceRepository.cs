using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class ServiceRepository : IService
    {
        private DB_Context db;
        public ServiceRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Service> GetServices => db.Services;

        public void Add(Service service)
        {
            db.Services.Add(service);
            db.SaveChanges();

        }

        public void Delete(int? Id)
        {
            Service dbEntity = db.Services.Find(Id);
            db.Services.Remove(dbEntity);
            db.SaveChanges();
        }

        public Service GetService(int Id)
        {
            Service dbEntity = db.Services.Find(Id);
            return dbEntity;
        }
    }
}
