using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Store_For_Musical_Instrument.Models
{
    public class OrderMaster
    {
        [Key]
        public int OrderMasterID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentMode { get; set; }
        public int TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public string OrderType { get; set; }

        public Nullable<int> ProductID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> AddressID { get; set; }

        public virtual User User { get; set; }
        public virtual DeliveryAddress DeliveryAddress { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}