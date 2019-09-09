using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class AdminRepository : IAdmin
    {
        public IEnumerable<Admin> GetAdmins => throw new NotImplementedException();

        public void Add(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public Admin GetAdmin(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
