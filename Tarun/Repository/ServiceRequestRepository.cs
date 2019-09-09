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
        public IEnumerable<ServiceRequest> GetServiceRequests => throw new NotImplementedException();

        public void Add(ServiceRequest serviceRequest)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public ServiceRequest GetServiceRequest(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
