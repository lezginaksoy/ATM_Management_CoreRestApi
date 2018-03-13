using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ATM_Management_CoreRestApi.Models
{
    public class AtmManagmentContext : DbContext
    {
     
    
        public AtmManagmentContext(DbContextOptions opts) : base(opts)
        {
        }

        public DbSet<Terminal> Terminals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Terminal>().ToTable("Terminal");

            builder.HasDefaultSchema("ATM_MNG");

            //builder.Entity<Terminal>()
            //    .Property(s => s.BrandId)
            //    .HasDefaultValue("1");

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

    }
}
