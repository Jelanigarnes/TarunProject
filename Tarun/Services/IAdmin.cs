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
        Admin GetAdmin(int Id);
        void Add(Admin admin);
        void Delete(int? Id);
    }
}
