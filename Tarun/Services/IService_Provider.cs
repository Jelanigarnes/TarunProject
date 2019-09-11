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
        Service_Provider GetService_Provider(int? ID);
        void Add(Service_Provider _Service_Provider);
        void Remove(int? ID);
    }
}
