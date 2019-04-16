using System;
using System.Collections.Generic;
using System.Text;

using CarService.Dal.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarService.Dal
{
    public class CarServiceDbContext : IdentityDbContext<ClientUser>
    {
        public CarServiceDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
        //public DbSet<ClientUser> ClientUsers { get; set; }
        //public DbSet<Company> Companies { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<Work> Works { get; set; }
        //public DbSet<WorkerUser> WorkerUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientUser>(e =>
            {
                e.OwnsOne(o => o.Address);
            });

            modelBuilder.Entity<Company>(e =>
            {
                e.OwnsOne(o => o.Address);
            });

            //modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<ClientUser>().ToTable("ClientUser", "dbo");
            modelBuilder.Entity<WorkerUser>().ToTable("WorkerUser", "dbo");
            modelBuilder.Entity<Company>().ToTable("Company", "dbo");
        }
    }
}
