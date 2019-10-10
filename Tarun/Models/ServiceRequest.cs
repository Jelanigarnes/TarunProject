using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public enum Status
        {
          Open,closed,assigned,Cancel
        }
    public class ServiceRequest
    {
        [Key]
        public int ServiceRequestID { get; set; }

        [DisplayName("Service Requester")]
        public int Service_RequesterID { get; set; }
        public Service_Requester Service_Requester { get; set; }

        [DisplayName("Service")]
        public int ServiceID { get; set; }
        public Service Service { get; set; }

        [DisplayName("Service Start Time")]
        public DateTime SRStartTime { get; set; }
        [DisplayName("Service End Time")]
        public DateTime SREndTime { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        [DisplayName("Apartment/House")]
        public string APT_House { get; set; }
        public Status? Status { get;set; }

       
       
    }
}
