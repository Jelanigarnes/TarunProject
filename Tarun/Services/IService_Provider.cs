using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;

namespace Tarun.Services
{
    public interface IService_Provider
    {
        IEnumerable<Service_Provider> GetService_Providers { get; }
        Service_Provider GetService_Provider(int Id);
        void Add(Service_Provider service_Provider);
        void Delete(int? Id);
    }
}
