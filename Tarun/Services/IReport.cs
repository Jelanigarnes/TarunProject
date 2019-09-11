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
        Report GetReport(int? ID);
        void Add(Report _Report);
        void Remove(int? ID);
    }
}
