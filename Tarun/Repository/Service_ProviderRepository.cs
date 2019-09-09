using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class Service_ProviderRepository : IService_Provider
    {
        public IEnumerable<Service_Provider> GetService_Providers => throw new NotImplementedException();

        public void Add(Service_Provider service_Provider)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public Service_Provider GetService_Provider(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
