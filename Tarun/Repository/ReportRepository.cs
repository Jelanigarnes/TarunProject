using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;
using Tarun.Services;

namespace Tarun.Repository
{   
    public class ReportRepository : IReport
    {
        private DB_Context db;
        public ReportRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Report> GetReports => db.Reports;

        public void Add(Report _Report)
        {
            db.Reports.Add(_Report);
            db.SaveChanges();
        }

        public void Remove(int? ID)
        {
            Report dbEntity = db.Reports.Find(ID);
            db.Reports.Remove(dbEntity);
            db.SaveChanges();
        }

        public Report GetReport(int? ID)
        {
            Report dbEntity = db.Reports.Find(ID);
            return dbEntity;
        }
    }
}
