using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class Service_ProviderRepository : IService_Provider
    {
        private DB_Context db;
        public Service_ProviderRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Service_Provider> GetService_Providers => db.Service_Providers;

        public void Add(Service_Provider _Service_Provider)
        {
            db.Service_Providers.Add(_Service_Provider);
            db.SaveChanges();
        }

        public void Remove(int? ID)
        {
            Service_Provider dbEntity = db.Service_Providers.Find(ID);
            db.Service_Providers.Remove(dbEntity);
            db.SaveChanges();
        }

        public Service_Provider GetService_Provider(int? ID)
        {
            Service_Provider dbEntity = db.Service_Providers.Find(ID);
            return dbEntity;
        }
    }
}
