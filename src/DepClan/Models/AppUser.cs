using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DepClan.Models
{
    public class AppUser: IdentityUser
    {
        public bool Admin { get; set; }
    }
}
