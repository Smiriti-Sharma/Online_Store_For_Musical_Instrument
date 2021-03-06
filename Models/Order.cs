using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Store_For_Musical_Instrument.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public Nullable<int> ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int OrderMasterID { get; set; }
        [Required]
        public virtual OrderMaster OrderMaster { get; set; }
    }
}