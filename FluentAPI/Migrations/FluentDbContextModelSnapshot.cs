﻿// <auto-generated />
using FluentAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FluentAPI.Migrations
{
    [DbContext(typeof(FluentDbContext))]
    partial class FluentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FluentAPI.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("FluentAPI.Models.CarSalon", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("integer");

                    b.Property<int>("SalonId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("CarId", "SalonId");

                    b.HasIndex("SalonId");

                    b.ToTable("CarSalon");
                });

            modelBuilder.Entity("FluentAPI.Models.Passport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Middlename")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Passports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            Lastname = "Doe",
                            Middlename = "M",
                            Name = "John",
                            Nation = "USA"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Oak St",
                            Lastname = "Doe",
                            Middlename = "N",
                            Name = "Jane",
                            Nation = "Canada"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Elm St",
                            Lastname = "Smith",
                            Middlename = "A",
                            Name = "Alice",
                            Nation = "UK"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Pine St",
                            Lastname = "Johnson",
                            Middlename = "B",
                            Name = "Bob",
                            Nation = "Australia"
                        },
                        new
                        {
                            Id = 5,
                            Address = "202 Maple St",
                            Lastname = "Williams",
                            Middlename = "E",
                            Name = "Eva",
                            Nation = "Germany"
                        },
                        new
                        {
                            Id = 6,
                            Address = "303 Birch St",
                            Lastname = "Brown",
                            Middlename = "C",
                            Name = "Charlie",
                            Nation = "France"
                        },
                        new
                        {
                            Id = 7,
                            Address = "404 Cedar St",
                            Lastname = "Jones",
                            Middlename = "G",
                            Name = "Grace",
                            Nation = "Spain"
                        });
                });

            modelBuilder.Entity("FluentAPI.Models.PersonCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("PersonCars");
                });

            modelBuilder.Entity("FluentAPI.Models.Salon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Salons");
                });

            modelBuilder.Entity("FluentAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PassportId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PassportId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FluentAPI.Models.CarSalon", b =>
                {
                    b.HasOne("FluentAPI.Models.Car", "Car")
                        .WithMany("CarSalons")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("FluentAPI.Models.Salon", "Salon")
                        .WithMany()
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("FluentAPI.Models.PersonCar", b =>
                {
                    b.HasOne("FluentAPI.Models.Car", "Car")
                        .WithMany("PersonCars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FluentAPI.Models.User", "User")
                        .WithMany("PersonCars")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FluentAPI.Models.User", b =>
                {
                    b.HasOne("FluentAPI.Models.Passport", "Passport")
                        .WithOne("User")
                        .HasForeignKey("FluentAPI.Models.User", "PassportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passport");
                });

            modelBuilder.Entity("FluentAPI.Models.Car", b =>
                {
                    b.Navigation("CarSalons");

                    b.Navigation("PersonCars");
                });

            modelBuilder.Entity("FluentAPI.Models.Passport", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("FluentAPI.Models.User", b =>
                {
                    b.Navigation("PersonCars");
                });
#pragma warning restore 612, 618
        }
    }
}
