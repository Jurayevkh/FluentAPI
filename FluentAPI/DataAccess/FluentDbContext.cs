using System;
using FluentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI.DataAccess
{
	public class FluentDbContext:DbContext
	{
		public FluentDbContext(DbContextOptions<FluentDbContext> options): base(options)
		{

		}

		public DbSet<Car> Cars { get; set; }
        public DbSet<CarSalon> CarSalon { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<PersonCar> PersonCars { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(u => u.Passport)
                .WithOne(p => p.User)
                .HasForeignKey<User>(u => u.PassportId);

            modelBuilder.Entity<Passport>().HasData(
            new Passport
            {
                Id = 1,
                Name = "John",
                Lastname = "Doe",
                Middlename = "M",
                Address = "123 Main St",
                Nation = "USA"
            },
            new Passport
            {
                Id = 2,
                Name = "Jane",
                Lastname = "Doe",
                Middlename = "N",
                Address = "456 Oak St",
                Nation = "Canada"
            },
            // Add more seed data entries
            new Passport
            {
                Id = 3,
                Name = "Alice",
                Lastname = "Smith",
                Middlename = "A",
                Address = "789 Elm St",
                Nation = "UK"
            },
            new Passport
            {
                Id = 4,
                Name = "Bob",
                Lastname = "Johnson",
                Middlename = "B",
                Address = "101 Pine St",
                Nation = "Australia"
            },
            new Passport
            {
                Id = 5,
                Name = "Eva",
                Lastname = "Williams",
                Middlename = "E",
                Address = "202 Maple St",
                Nation = "Germany"
            },
            new Passport
            {
                Id = 6,
                Name = "Charlie",
                Lastname = "Brown",
                Middlename = "C",
                Address = "303 Birch St",
                Nation = "France"
            },
            new Passport
            {
                Id = 7,
                Name = "Grace",
                Lastname = "Jones",
                Middlename = "G",
                Address = "404 Cedar St",
                Nation = "Spain"
            }
        );

            modelBuilder.Entity<PersonCar>()
                .HasOne(pc => pc.Car)
                .WithMany(c => c.PersonCars)
                .HasForeignKey(pc => pc.CarId);

            modelBuilder.Entity<Car>()
                .HasMany(c => c.PersonCars)
                .WithOne(pc => pc.Car)
                .HasForeignKey(pc => pc.CarId);

            modelBuilder.Entity<CarSalon>()
                .HasKey(cs => new { cs.CarId, cs.SalonId });

            modelBuilder.Entity<CarSalon>()
                .HasOne(cs => cs.Car)
                .WithMany(cs => cs.CarSalons)
                .HasForeignKey(cs => cs.CarId)
                .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }
    }
}

