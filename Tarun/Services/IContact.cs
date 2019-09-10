using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;

namespace Tarun.Services
{
    public interface IContact
    {
        IEnumerable<Contact> GetContacts { get; }
        Contact GetContact(int ID);
        void Add(Contact _Contact);
        void Remove(int? ID);
    }
}
