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

        public void Add(Report report)
        {
            db.Reports.Add(report);
            db.SaveChanges();
        }

        public void Delete(int? Id)
        {
            Report dbEntity = db.Reports.Find(Id);
            db.Reports.Remove(dbEntity);
            db.SaveChanges();
        }

        public Report GetReport(int Id)
        {
            Report dbEntity = db.Reports.Find(Id);
            return dbEntity;
        }
    }
}
