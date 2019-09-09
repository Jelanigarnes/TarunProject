using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class Service_Provider
    {
        [Key]
        public int ServiceProviderID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string LoginID { get; set; }
        public string CreationTimeStamp { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedTimeStamp { get; set; }
        public string ModifiedBy { get; set; }
        public int Image { get; set; }
        public int ServiceRequesterID { get; set; }
        public int ServiceRequestID { get; set; }
    }



}
