using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;

namespace Tarun.Services
{
    public interface IServiceRequester
    {
        IEnumerable<ServiceRequester> GetServiceRequesters { get; }
        ServiceRequester GetServiceRequest(int Id);
        void Add(ServiceRequester serviceRequest);
        void Delete(int? Id);
    }
}
