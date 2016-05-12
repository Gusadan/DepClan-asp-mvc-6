using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DepClan.Models
{
    public class Query
    {
        //TODO: make custom error message

        public int QueryId { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(1024, MinimumLength = 8)]
        public string Message { get; set; }
    }
}
