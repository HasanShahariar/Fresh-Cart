using Fresh_Cart.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fresh_Cart.DatabaseOps
{
    public class FCDBContext:DbContext
    {
        public FCDBContext()
        {

        }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(local); Database=FCDB; Integrated Security=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
