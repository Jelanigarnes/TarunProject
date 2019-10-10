using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Data;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{
    public class AdminRepository : IAdmin
    {
        private ApplicationDbContext db;
        public AdminRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IEnumerable<Admin> GetAdmins => db.Admins;

        public void Add(Admin _Admin)
        {
            db.Admins.Add(_Admin);
            db.SaveChanges();
        }

        public void Remove(int? ID)
        {
            Admin dbEntity = db.Admins.Find(ID);
            db.Admins.Remove(dbEntity);
            db.SaveChanges();
        }

        public Admin GetAdmin(int? ID)
        {
            Admin dbEntity = db.Admins.Find(ID);
            return dbEntity;
        }
    }
}
