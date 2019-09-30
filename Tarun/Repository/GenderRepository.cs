using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class GenderRepository : IGender
    {
        private DB_Context db;
        public GenderRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Gender> GetGenders => db.Genders;

        public void Add(Gender _Gender)
        {
            db.Genders.Add(_Gender);
            db.SaveChanges();
        }

        public Gender GetGender(int? ID)
        {
            Gender dbEntity = db.Genders.Find(ID);
            return dbEntity;
            
        }

        public void Remove(int? ID)
        {
            Gender dbEntity = db.Genders.Find(ID);
            db.Genders.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
