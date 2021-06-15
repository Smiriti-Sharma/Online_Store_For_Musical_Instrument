using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store_For_Musical_Instrument.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<double> Price { get; set; }
        public string Brand { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<int> QuantityOnHand { get; set; }
        public string ProductImage { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}