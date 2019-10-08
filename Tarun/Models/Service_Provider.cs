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

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is Required")]
        public int GenderID { get; set; }
        public Gender Genders { get; set; }

        [DisplayName("Services")]
        public int ServiceID { get; set; }

        public Service Services { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is Required")]
        public string ConfirmPassword { get; set; }
     
        
        
    }



}
