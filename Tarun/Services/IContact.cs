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
        Contact GetContact(int Id);
        void Add(Contact contact);
        void Delete(int? Id);
    }
}
