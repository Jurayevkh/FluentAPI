using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPI.Models
{
	public class User
	{
        [Key]
        public int Id { get; set; }

        [ForeignKey("Passport")]
        public int PassportId { get; set; }
        public Passport Passport { get; set; }

        public ICollection<PersonCar> PersonCars { get; set; }
    }
}

