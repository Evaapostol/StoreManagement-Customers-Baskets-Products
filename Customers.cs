using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace StoreManagement_Proj
{
    public class Customer 
    {
        [Key]
        [Column("Customer Id")]
        public int CustomerId { get; set; }
        [Column("Customer Name")]
        [Required(AllowEmptyStrings = false)]
        public string CustomerName { get; set; }
        [Display(Name = "Street Address")]
        public string Address { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        [Column("Baskets")]
        public List<Baskets> Baskets { get; set; }
        [Column("Date of birth")]
        public DateTime Dob { get; set; }
        [Column("Registration date")]
        public string Register { get; set; }
        public bool Active { get; set; }

        public Customer()
        {
            Baskets = new List<Baskets>();
        }


        public override string ToString()
        {
            return $"{CustomerId}:{CustomerName}:{Address}:{Email}:{Dob}:{Register}";
        }

        


    }

}
