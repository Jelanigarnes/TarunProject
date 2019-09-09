using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class ContactRepository : IContact
    {
        public IEnumerable<Contact> GetContacts => throw new NotImplementedException();

        public void Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public Contact GetContact(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
