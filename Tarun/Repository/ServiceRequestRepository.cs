using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class ServiceRequestRepository : IServiceRequest
    {
        private DB_Context db;
        public ServiceRequestRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<ServiceRequest> GetServiceRequests => db.ServiceRequests;

        public void Add(ServiceRequest _ServiceRequest)
        {
            db.ServiceRequests.Add(_ServiceRequest);
            db.SaveChanges();
        }

        public void Remove(int? ID)
        {
            ServiceRequest dbEntity = db.ServiceRequests.Find(ID);
            db.ServiceRequests.Remove(dbEntity);
            db.SaveChanges();
        }

        public ServiceRequest GetServiceRequest(int? ID)
        {
            ServiceRequest dbEntity = db.ServiceRequests.Find(ID);
            return dbEntity;
        }
    }
}
