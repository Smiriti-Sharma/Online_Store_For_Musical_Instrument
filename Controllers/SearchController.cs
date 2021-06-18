using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Online_Store_For_Musical_Instrument.Data;
using Online_Store_For_Musical_Instrument.Models;

namespace Online_Store_For_Musical_Instrument.Controllers
{
    public class SearchController : ApiController
    {

        private Online_Store_For_Musical_InstrumentContext db = new Online_Store_For_Musical_InstrumentContext();

        [HttpGet]
        [ResponseType(typeof(Product))]
        public IEnumerable<Product> SearchByProductName(string name1)
        {
            var matches = db.Products.Where(r => r.ProductName == name1);
            //return matches.Count() > 0 ? matches.First() : null;
            return matches;
        }

        

    }
}
