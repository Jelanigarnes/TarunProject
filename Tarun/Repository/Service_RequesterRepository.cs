using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class Service_RequesterRepository : IService_Requester
    {
        private DB_Context db;
        public Service_RequesterRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Service_Requester> GetService_Requesters => db.Service_Requesters;

        public void Add(Service_Requester _Service_Requester)
        {
            db.Service_Requesters.Add(_Service_Requester);
            db.SaveChanges();
        }

        public void Remove(int? ID)
        {
            Service_Requester dbEntity = db.Service_Requesters.Find(ID);
            db.Service_Requesters.Remove(dbEntity);
            db.SaveChanges();
        }

        public Service_Requester GetService_Requester(int? ID)
        {
            Service_Requester dbEntity = db.Service_Requesters.Find(ID);
            return dbEntity;
        }
    }
}
