using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Online_Store_For_Musical_Instrument.Models
{
    public class DeliveryAddress
    {
        [Key]
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }
        public Nullable<int> CustomerID { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Order> OrderMaster { get; set; }
    }
}