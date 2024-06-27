using Microsoft.EntityFrameworkCore;
using SVHDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVHDB
{
    public class DataContecDocBody : DbContext
    {
        public DbSet<DocBody> DocBody { get; set; }


        public DataContecDocBody()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocBody>().HasKey(x => new {x.Id});

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=studadmin;Database=SVHDocBody");
            base.OnConfiguring(optionsBuilder);
     
        }
    }
}
