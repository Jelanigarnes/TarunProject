using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
namespace Tarun.Services
{
    public interface IService
    {

        IEnumerable<Service> GetServices { get; }
        Service GetService (int Id);
        void Add(Service service);
        void Delete(int? Id);

    }
}
