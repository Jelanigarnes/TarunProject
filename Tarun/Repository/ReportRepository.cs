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
        public IEnumerable<Report> GetReports => throw new NotImplementedException();

        public void Add(Report report)
        {
            throw new NotImplementedException();
        }

        public void Delete(int? Id)
        {
            throw new NotImplementedException();
        }

        public Report GetReport(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
