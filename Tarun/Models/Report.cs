using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }
        
        [DisplayName("Service Request")]
        public int ServiceRequestID { get; set; }

        [DisplayName("Service")]
        public int ServiceID { get; set; }

        [DisplayName("Service Provider")]
        public int Service_ProviderID { get; set; }

        [DisplayName("Service Requester")]
        public int Service_RequesterID { get; set; }

        [DisplayName("Gender")]
        public int GenderID { get; set; }

        [DisplayName("Contact")]
        public int ContactID { get; set; }

    }
}
