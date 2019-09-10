using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class AdminRepository : IAdmin
    {
        private DB_Context db;
        public AdminRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Admin> GetAdmins => db.Admins;

        public void Add(Admin admin)
        {
            db.Admins.Add(admin);
            db.SaveChanges();
        }

        public void Delete(int? Id)
        {
            Admin dbEntity = db.Admins.Find(Id);
            db.Admins.Remove(dbEntity);
            db.SaveChanges();
        }

        public Admin GetAdmin(int Id)
        {
            Admin dbEntity = db.Admins.Find(Id);
            return dbEntity;
        }
    }
}
