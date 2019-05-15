using System;
using System.Collections.Generic;
using System.Text;

using CarService.Dal.Entities;
using CarService.Dal.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarService.Dal
{
    public class CarServiceDbContext : IdentityDbContext<User, IdentityRole<string>, string>
    {
        public CarServiceDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Opening> Openings { get; set; }

        //Users
        public DbSet<WorkerUser> WorkerUsers { get; set; }
        public DbSet<ClientUser> ClientUsers { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(e =>
            {
                e.OwnsOne(o => o.Address);
            });

            modelBuilder.Entity<Opening>(e =>
            {
                e.OwnsOne(o => o.Monday);
                e.OwnsOne(o => o.Tuesday);
                e.OwnsOne(o => o.Wednesday);
                e.OwnsOne(o => o.Thursday);
                e.OwnsOne(o => o.Friday);
                e.OwnsOne(o => o.Saturday);
                e.OwnsOne(o => o.Sunday);
            });

            modelBuilder.Entity<User>().ToTable("Users").HasDiscriminator<UserType>("UserType")
                .HasValue<ClientUser>(UserType.CLIENT)
                .HasValue<WorkerUser>(UserType.WORKER)
                .HasValue<CompanyUser>(UserType.COMPANY);

            modelBuilder.Entity<State>().HasData(
                new State { Id = 1, Name = "Requested", NameHungarian = "Jóváhagyásra vár" },
                new State { Id = 2, Name = "Accepted", NameHungarian = "Leadva" },
                new State { Id = 3, Name = "Begun", NameHungarian = "Elkezdve" },
                new State { Id = 4, Name = "Paid", NameHungarian = "Kifizetve" },
                new State { Id = 5, Name = "Finished", NameHungarian = "Befejezett" },
                new State { Id = 6, Name = "PaidAndFinished", NameHungarian = "Kifizetve és befejezve" });
        }
    }
}
