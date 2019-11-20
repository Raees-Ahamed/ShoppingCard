using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCard.Data.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Fname { get; set; }
        [Required]
        [MaxLength(60)]
        public string Lname { get; set; }

        public int Telephone { get; set; }
        [Required]
        [MaxLength(60)]
        public string Address { get; set; }
    }
}
