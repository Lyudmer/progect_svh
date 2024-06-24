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
            modelBuilder.Entity<DocBody>()
                .HasKey(db => new { db.Id, db.Idmd5, db.IdSha256 });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=studotus;Database=SVHDocBody");
            base.OnConfiguring(optionsBuilder);
            {
            }
        }
    }
}
