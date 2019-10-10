using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;

namespace Tarun.Services
{
    public interface IGender
    {
        IEnumerable<Gender> GetGenders { get; }
        Gender GetGender(int? ID);
        void Add(Gender _Gender);
        void Remove(int? ID);
    }
}
