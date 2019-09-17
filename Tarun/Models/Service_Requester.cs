using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class Service_Requester
    {
        [Key]
        public int Service_RequesterID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }  

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        [DisplayName("Creation Time Stamp")]
        public DateTime CreationTimeStamp { get; set; }

        [DisplayName("Created By")]
        public string CreatedBy { get; set; }

        [DisplayName("Modified Time Stamp")]
        public DateTime ModifiedTimeStamp { get; set; }

        [DisplayName("Modified By")]
        public string ModifiedBy { get; set; }
        public string Image { get; set; }
        
    }

}
