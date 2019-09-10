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
        private DB_Context db;
        public ContactRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Contact> GetContacts => db.Contacts;

        public void Add(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        public void Delete(int? Id)
        {
            Contact dbEntity = db.Contacts.Find(Id);
            db.Contacts.Remove(dbEntity);
            db.SaveChanges();
        }

        public Contact GetContact(int Id)
        {
            Contact dbEntity = db.Contacts.Find(Id);
            return dbEntity;
        }
    }
}
