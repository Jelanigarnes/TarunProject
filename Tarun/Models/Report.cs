using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }
        public string ReportTitle { get; set; }
        public int ServiceRequestID { get; set; }
        public int ServiceProviderID { get; set; }
        public int ServiceID { get; set; }
        public int ServiceRequesterID { get; set; }
        public int CreationTimeStamp { get; set; }
        public int CreatedBy { get; set; }
    }
}
