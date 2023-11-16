using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPI.Models
{
	public class CarSalon
	{
        [Key]
        public int Id { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }

        [ForeignKey("Salon")]
        public int SalonId { get; set; }
        public Salon Salon { get; set; }
    }
}

