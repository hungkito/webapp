using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapp;

namespace webapp.Data
{
    public class webappContext : DbContext
    {
        public webappContext (DbContextOptions<webappContext> options)
            : base(options)
        {
        }

        public DbSet<webapp.Product> Product { get; set; }

        public DbSet<webapp.Category> Category { get; set; }
    }
}
