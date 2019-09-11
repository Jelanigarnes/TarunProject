using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class ServiceRequesterRepository : IServiceRequester
    {
        private DB_Context db;
        public ServiceRequesterRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<ServiceRequester> GetServiceRequesters => db.ServiceRequesters;

        public void Add(ServiceRequester _ServiceRequester)
        {
            db.ServiceRequesters.Add(_ServiceRequester);
            db.SaveChanges();
        }

        public void Remove(int? ID)
        {
            ServiceRequester dbEntity = db.ServiceRequesters.Find(ID);
            db.ServiceRequesters.Remove(dbEntity);
            db.SaveChanges();
        }

        public ServiceRequester GetServiceRequest(int? ID)
        {
            ServiceRequester dbEntity = db.ServiceRequesters.Find(ID);
            return dbEntity;
        }
    }
}
