using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCard.Data.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Required]
        [MaxLength(60)]
        public string Description { get; set; }
        public int QtyInHand { get; set; }
        public int UnitPrice { get; set; }
    }
}
