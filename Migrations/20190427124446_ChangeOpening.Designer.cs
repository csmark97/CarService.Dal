﻿// <auto-generated />
using System;
using CarService.Dal;
using CarService.Dal.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarService.Dal.Migrations
{
    [DbContext(typeof(CarServiceDbContext))]
    [Migration("20190427124446_ChangeOpening")]
    partial class ChangeOpening
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarService.Dal.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("ClientUserId");

                    b.Property<int>("Km");

                    b.Property<string>("LicensePlateNumber");

                    b.Property<string>("Model");

                    b.Property<string>("Picture");

                    b.Property<DateTime>("TechnicalValidity");

                    b.Property<string>("Vin");

                    b.Property<int>("YearOfManufacture");

                    b.HasKey("Id");

                    b.HasIndex("ClientUserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarService.Dal.Entities.Opening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndFriday");

                    b.Property<DateTime>("EndMonday");

                    b.Property<DateTime?>("EndSaturday");

                    b.Property<DateTime?>("EndSunday");

                    b.Property<DateTime>("EndThursday");

                    b.Property<DateTime>("EndTuesday");

                    b.Property<DateTime>("EndWednesday");

                    b.Property<bool>("SaturdayOpen");

                    b.Property<DateTime>("StartFriday");

                    b.Property<DateTime>("StartMonday");

                    b.Property<DateTime?>("StartSaturday");

                    b.Property<DateTime?>("StartSunday");

                    b.Property<DateTime>("StartThursday");

                    b.Property<DateTime>("StartTuesday");

                    b.Property<DateTime>("StartWednesday");

                    b.Property<bool>("SundayOpen");

                    b.HasKey("Id");

                    b.ToTable("Openings");
                });

            modelBuilder.Entity("CarService.Dal.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Invoice");

                    b.Property<DateTime>("StartingTime");

                    b.Property<int>("TotalPrice");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("CarService.Dal.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("CarService.Dal.Entities.SubTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("CompanyId1");

                    b.Property<int>("EstimatedPrice");

                    b.Property<int>("EstimtedTime");

                    b.Property<string>("Name");

                    b.Property<string>("Picture");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId1");

                    b.ToTable("SubTasks");
                });

            modelBuilder.Entity("CarService.Dal.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Picture");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasDiscriminator<int>("UserType");
                });

            modelBuilder.Entity("CarService.Dal.Entities.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyDescription");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("OwnerDescription");

                    b.Property<int>("Price");

                    b.Property<int>("ServiceId");

                    b.Property<DateTime>("StartingTime");

                    b.Property<int>("StateId");

                    b.Property<int>("SubTaskId");

                    b.Property<string>("WorkerUserId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("StateId");

                    b.HasIndex("SubTaskId");

                    b.HasIndex("WorkerUserId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<string>", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CarService.Dal.Entities.ClientUser", b =>
                {
                    b.HasBaseType("CarService.Dal.Entities.User");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("CarService.Dal.Entities.CompanyUser", b =>
                {
                    b.HasBaseType("CarService.Dal.Entities.User");

                    b.Property<int>("OpeningId");

                    b.Property<string>("PrivateKey");

                    b.HasIndex("OpeningId")
                        .IsUnique()
                        .HasFilter("[OpeningId] IS NOT NULL");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("CarService.Dal.Entities.WorkerUser", b =>
                {
                    b.HasBaseType("CarService.Dal.Entities.User");

                    b.Property<string>("CompanyUserId");

                    b.HasIndex("CompanyUserId");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("CarService.Dal.Entities.Car", b =>
                {
                    b.HasOne("CarService.Dal.Entities.ClientUser", "ClientUser")
                        .WithMany("Cars")
                        .HasForeignKey("ClientUserId");
                });

            modelBuilder.Entity("CarService.Dal.Entities.Service", b =>
                {
                    b.HasOne("CarService.Dal.Entities.Car", "Car")
                        .WithMany("Services")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarService.Dal.Entities.SubTask", b =>
                {
                    b.HasOne("CarService.Dal.Entities.CompanyUser", "Company")
                        .WithMany("SubTasks")
                        .HasForeignKey("CompanyId1");
                });

            modelBuilder.Entity("CarService.Dal.Entities.User", b =>
                {
                    b.OwnsOne("CarService.Dal.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<string>("UserId");

                            b1.Property<string>("City");

                            b1.Property<int?>("HouseNumber");

                            b1.Property<string>("Street");

                            b1.Property<int?>("Zip");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.HasOne("CarService.Dal.Entities.User")
                                .WithOne("Address")
                                .HasForeignKey("CarService.Dal.Entities.Address", "UserId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("CarService.Dal.Entities.Work", b =>
                {
                    b.HasOne("CarService.Dal.Entities.Service", "Service")
                        .WithMany("Works")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarService.Dal.Entities.State", "State")
                        .WithMany("Works")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarService.Dal.Entities.SubTask", "SubTask")
                        .WithMany("Works")
                        .HasForeignKey("SubTaskId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarService.Dal.Entities.WorkerUser", "WorkerUser")
                        .WithMany("Works")
                        .HasForeignKey("WorkerUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<string>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarService.Dal.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarService.Dal.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<string>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarService.Dal.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarService.Dal.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarService.Dal.Entities.CompanyUser", b =>
                {
                    b.HasOne("CarService.Dal.Entities.Opening", "Opening")
                        .WithOne("CompanyUser")
                        .HasForeignKey("CarService.Dal.Entities.CompanyUser", "OpeningId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarService.Dal.Entities.WorkerUser", b =>
                {
                    b.HasOne("CarService.Dal.Entities.CompanyUser", "CompanyUser")
                        .WithMany("WorkerUsers")
                        .HasForeignKey("CompanyUserId");
                });
#pragma warning restore 612, 618
        }
    }
}