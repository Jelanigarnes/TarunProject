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

        public void Add(Service _Service)
        {
            db.Services.Add(_Service);
            db.SaveChanges();

        }

        public void Remove(int? ID)
        {
            Service dbEntity = db.Services.Find(ID);
            db.Services.Remove(dbEntity);
            db.SaveChanges();
        }

        public Service GetService(int ID)
        {
            Service dbEntity = db.Services.Find(ID);
            return dbEntity;
        }
    }
}
