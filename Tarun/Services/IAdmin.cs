using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;

namespace Tarun.Services
{
    public interface IAdmin
    {
        IEnumerable<Admin> GetAdmins { get; }
        Admin GetAdmin(int? ID);
        void Add(Admin _Admin);
        void Remove(int? ID);
    }
}
