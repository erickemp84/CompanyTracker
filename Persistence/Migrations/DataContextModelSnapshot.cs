﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("BillablesPunch", b =>
                {
                    b.Property<Guid>("BillablesId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PunchId")
                        .HasColumnType("TEXT");

                    b.HasKey("BillablesId", "PunchId");

                    b.HasIndex("PunchId");

                    b.ToTable("BillablesPunch");
                });

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("PunchId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PunchId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Domain.AppUserCrews", b =>
                {
                    b.Property<Guid>("AppUserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CrewsId")
                        .HasColumnType("TEXT");

                    b.HasKey("AppUserId", "CrewsId");

                    b.HasIndex("CrewsId");

                    b.ToTable("AppUserCrews");
                });

            modelBuilder.Entity("Domain.Billables", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Billables");
                });

            modelBuilder.Entity("Domain.Crews", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Crews");
                });

            modelBuilder.Entity("Domain.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Domain.Job", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Customer")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PunchId")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("PunchId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Domain.Punch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClockIn")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClockInLongLat")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClockOut")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClockOutLongLat")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Punches");
                });

            modelBuilder.Entity("BillablesPunch", b =>
                {
                    b.HasOne("Domain.Billables", null)
                        .WithMany()
                        .HasForeignKey("BillablesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Punch", null)
                        .WithMany()
                        .HasForeignKey("PunchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.HasOne("Domain.Punch", null)
                        .WithMany("AppUser")
                        .HasForeignKey("PunchId");
                });

            modelBuilder.Entity("Domain.AppUserCrews", b =>
                {
                    b.HasOne("Domain.AppUser", "AppUser")
                        .WithMany("Crews")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Crews", "Crews")
                        .WithMany("AppUsers")
                        .HasForeignKey("CrewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Crews");
                });

            modelBuilder.Entity("Domain.Job", b =>
                {
                    b.HasOne("Domain.Punch", null)
                        .WithMany("Job")
                        .HasForeignKey("PunchId");
                });

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Navigation("Crews");
                });

            modelBuilder.Entity("Domain.Crews", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("Domain.Punch", b =>
                {
                    b.Navigation("AppUser");

                    b.Navigation("Job");
                });
#pragma warning restore 612, 618
        }
    }
}
