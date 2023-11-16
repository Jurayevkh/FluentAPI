using System;
using System.ComponentModel.DataAnnotations;

namespace FluentAPI.Models
{
	public class Passport
	{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Address { get; set; }
        public string Nation { get; set; }

        public User User { get; set; }
    }
}

