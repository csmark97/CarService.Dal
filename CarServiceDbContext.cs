using System;
using System.Collections.Generic;
using System.Text;

using CarService.Dal.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarService.Dal
{
    public class CarServiceDbContext : IdentityDbContext<ApplicationUser>
    {
        public CarServiceDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Company> Companies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                        .ToTable("ApplicationUser", "dbo");

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Autós Bázis Kft.",
                    Zip = 3849,
                    City = "Forró",
                    Street = "Fő út",
                    HouseNumber = 188,
                    PrivateKey = "RNckqbbS"
                });
        }
    }
}
