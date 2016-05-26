using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DepClan.Models
{
    public class Register
    {
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        
        public string LastName { get; set; }

        public string Gender { get; set; }

        public bool Admin { get; set; }

        public DateTime JoidDate { get; set; }

    }   
}
