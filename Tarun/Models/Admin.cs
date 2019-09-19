using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [DisplayName("Admin First Name")]
        [Required(ErrorMessage ="First Name is Required")]
        public string AdminFirstName { get; set; }

        [DisplayName("Admin Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string AdminLastName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [DisplayName("Report")]
        public int ReportID { get; set; }

        [DisplayName("Service")]
        public int ServiceID { get; set; }

        [DisplayName("Service Request")]
        public int ServiceRequestID { get; set; }

        [DisplayName("Contact")]
        public int ContactID { get; set; }

        [DisplayName("Servive Requester")]
        public int Service_RequesterID { get; set; }
        [DisplayName("Service Provider")]
        public int Service_ProviderID { get; set; }
    }
}
