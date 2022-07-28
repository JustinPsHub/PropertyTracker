using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PropertyTracker.Models;

namespace PropertyTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
   
        }


        // public DbSet<Barn> Barns { get; set; }
        public DbSet<Building> Buildings { get; set; }
        // public DbSet<Land> Land { get; set; }
         public DbSet<Barn> Barns { get; set; }
        public DbSet<Garden> Gardens { get; set; }

        public DbSet<Renovation> Renovations { get; set; }

        public DbSet<Pond> Ponds { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Plant> Plants { get; set; }


    }
}