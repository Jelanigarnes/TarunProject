using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ReportID { get; set; }
        public int ServiceID { get; set; }
        public int ServiceRequestID { get; set; }
        public int ContactID { get; set; }
        public int ServiceRequesterID { get; set; }
        public int ServiceProviderID { get; set; }
    }
}
