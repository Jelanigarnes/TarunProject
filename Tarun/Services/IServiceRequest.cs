using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
namespace Tarun.Services
{
    public interface IServiceRequest
    {
        IEnumerable<ServiceRequest> GetServiceRequests { get; }
        ServiceRequest GetServiceRequest(int? ID);
        void Add(ServiceRequest _ServiceRequest);
        void Remove(int? ID);
    }
}
