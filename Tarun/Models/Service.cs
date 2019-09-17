using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        [DisplayName("Service Name")]
        [Required(ErrorMessage = "Service Name is Required")]
        public string ServiceName { get; set; }

        [DisplayName("Hourly Rate")]
        [Required(ErrorMessage = "Hourly Rate is Required")]
        public string Rate { get; set; }

        [DisplayName("Service Description")]
        [Required(ErrorMessage = "Service Description is Required")]
        public string ServiceDescription { get; set; }
        [DisplayName("Creation Time Stamp")]
        [Required(ErrorMessage = "Creation Time Stamp is Required")]
        public DateTime CreationTimeStamp { get; set; }
        [DisplayName("Created By")]
        public string CreatedBy { get; set; }
    }
}
