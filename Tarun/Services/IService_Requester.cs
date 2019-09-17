using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;

namespace Tarun.Services
{
    public interface IService_Requester
    {
        IEnumerable<Service_Requester> GetService_Requesters { get; }
        Service_Requester GetService_Requester(int? ID);
        void Add(Service_Requester _Service_Requester);
        void Remove(int? ID);
    }
}
