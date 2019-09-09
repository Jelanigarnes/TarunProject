using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class ServiceRepository : IService
    {
        public IEnumerable<Service> GetServices => throw new NotImplementedException();

        public void Add(Service service)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public Service GetService(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
