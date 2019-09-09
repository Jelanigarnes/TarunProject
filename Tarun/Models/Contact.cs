using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarun.Models
{
    public class Contact
    {
       [Key]
        public int ContactID { get; set; }
        public int ServiceRequesterID { get; set; }
        public int ServiceProviderID { get; set; }
        public string Street { get; set; }
        public string APT_House { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
