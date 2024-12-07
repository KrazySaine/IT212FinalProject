using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IT212FinalProject.Properties.Models;

namespace IT212FinalProject.Data
{
    public class IT212FinalProjectContext : DbContext
    {
        public IT212FinalProjectContext (DbContextOptions<IT212FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<IT212FinalProject.Properties.Models.Customers> Customers { get; set; } = default!;
        public DbSet<IT212FinalProject.Properties.Models.Orders> Orders { get; set; } = default!;
        public DbSet<IT212FinalProject.Properties.Models.Products> Products { get; set; } = default!;
    }
}
