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

        public void Add(ServiceRequester serviceRequester)
        {
            db.ServiceRequesters.Add(serviceRequester);
            db.SaveChanges();
        }

        public void Delete(int? Id)
        {
            ServiceRequester dbEntity = db.ServiceRequesters.Find(Id);
            db.ServiceRequesters.Remove(dbEntity);
            db.SaveChanges();
        }

        public ServiceRequester GetServiceRequest(int Id)
        {
            ServiceRequester dbEntity = db.ServiceRequesters.Find(Id);
            return dbEntity;
        }
    }
}
