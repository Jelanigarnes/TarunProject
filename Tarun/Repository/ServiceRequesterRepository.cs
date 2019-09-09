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
        public IEnumerable<ServiceRequester> GetServiceRequesters => throw new NotImplementedException();

        public void Add(ServiceRequester serviceRequest)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public ServiceRequester GetServiceRequest(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
