using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StoreManagement_Proj
{
    public class Product
    {
        [Key]
        [Column("Product Id")]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductCategoryId Category { get; set; }
        public List<Baskets> Baskets { get; set; }


        public Product()
        {
            Baskets = new List<Baskets>();
        }

        public override string ToString()
        {
            return $"{ProductId}:{Name}:{Price}:{Category.ToString()}";
        }
    }
}
