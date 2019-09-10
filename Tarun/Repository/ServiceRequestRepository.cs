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

        public void Add(ServiceRequest serviceRequest)
        {
            db.ServiceRequests.Add(serviceRequest);
            db.SaveChanges();
        }

        public void Delete(int? Id)
        {
            ServiceRequest dbEntity = db.ServiceRequests.Find(Id);
            db.ServiceRequests.Remove(dbEntity);
            db.SaveChanges();
        }

        public ServiceRequest GetServiceRequest(int Id)
        {
            ServiceRequest dbEntity = db.ServiceRequests.Find(Id);
            return dbEntity;
        }
    }
}
