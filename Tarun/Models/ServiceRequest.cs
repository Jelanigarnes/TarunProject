using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class ServiceRequest
    {
        [Key]
        public int ServiceRequestID { get; set; }
        public int ServiceRequesterID { get; set; }
        public int ServiceID { get; set; }
        public string Service { get; set; }
        public DateTime ServiceDate { get; set; }
        public DateTime SRStartTime { get; set; }
        public DateTime SREndTime { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        public string APT_House { get; set; }
        public string Location { get; set; }
    }
}
