using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarun.Models;

namespace Tarun.Services
{
    public interface IReport
    {

        IEnumerable<Report> GetReports{ get; }
        Report GetReport(int Id);
        void Add(Report report);
        void Delete(int? Id);
    }
}
