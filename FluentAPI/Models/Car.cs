using System;
using System.ComponentModel.DataAnnotations;

namespace FluentAPI.Models
{
	public class Car
	{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public ICollection<PersonCar> PersonCars { get; set; }
        public ICollection<CarSalon> CarSalons { get; set; }

    }
}

