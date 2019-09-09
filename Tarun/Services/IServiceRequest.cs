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
        ServiceRequest GetServiceRequest(int Id);
        void Add(ServiceRequest serviceRequest);
        void Delete(int? Id);
    }
}
