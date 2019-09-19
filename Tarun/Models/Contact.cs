using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public enum Province
    {
        ON,BC,AB,MB,NB,NL,NS,NT,NU,PE,QC,SK,YT
    }
    public class Contact
    {
       [Key]
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Street is Required")]
        public string Street { get; set; }

        [DisplayName("Apartmant/House")]
        [Required(ErrorMessage = "Apartmant/House is Required")]
        public string APT_House { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [DisplayName("Province")]
        [Required(ErrorMessage = "Province is Required")]
        public Province? Province { get; set; }

        [DisplayName("Postal Code")]
        [Required(ErrorMessage = "Postal code is Required")]
        public string PostalCode { get; set; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Country is Required")]
        public string Country { get; set; }

        
    }
}
