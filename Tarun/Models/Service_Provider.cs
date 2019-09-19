using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class Service_Provider
    {
        [Key]
        public int Service_ProviderID { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
        [DisplayName("Modified Time Stamp")]
        [Required(ErrorMessage = "Modified Time Stamp is Required")]
        public DateTime ModifiedTimeStamp { get; set; }
        [DisplayName("Modified By Stamp")]
        [Required(ErrorMessage = "Modified By is Required")]
        public string ModifiedBy { get; set; }
        public int Image { get; set; }
        
        
        [DisplayName("Service Request")]
        public int ServiceRequestID { get; set; }
    }



}
