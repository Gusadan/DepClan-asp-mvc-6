using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace DepClan.Models
{
    public class DepContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Query> Queries { get; set; }

        /*public DepContext()
        {
            Database.EnsureCreated();
        }*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
