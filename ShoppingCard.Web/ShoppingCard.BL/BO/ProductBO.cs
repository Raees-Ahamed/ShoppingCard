using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.BL.BO
{
    public class ProductBO
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
       
        public string Description { get; set; }

        public int QtyInHand { get; set; }

        public int UnitPrice { get; set; }
    }
}
