using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace StoreManagement_Proj
{
    public class Baskets
    {
        [Key]
        [Column("Basket Id")]
        public int BasketsId { get; set; }
        public List<Product> Products { get; set; }
        public Customer Customer { get; set; }


        public Baskets()
        {
            Products = new List<Product>();
        }

        public override string ToString()
        {
            return $"{BasketsId}:{Products}";
        }


    }
    
}
