﻿using System;
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

        public void Add(Contact _Contact)
        {
            db.Contacts.Add(_Contact);
            db.SaveChanges();
        }

        public void Remove(int? ID)
        {
            Contact dbEntity = db.Contacts.Find(ID);
            db.Contacts.Remove(dbEntity);
            db.SaveChanges();
        }

        public Contact GetContact(int? ID)
        {
            Contact dbEntity = db.Contacts.Find(ID);
            return dbEntity;
        }
    }
}
