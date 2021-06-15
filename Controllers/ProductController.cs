using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Online_Store_For_Musical_Instrument.Data.Repository;
using Online_Store_For_Musical_Instrument.Models;
using Online_Store_For_Musical_Instrument.Controllers;
using Online_Store_For_Musical_Instrument.Data.DataManager;

namespace Online_Store_For_Musical_Instrument.Controllers
{
    public class ProductController : ApiController
    {
        IDataRepository mydata = ProductManager.getRepository();

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return mydata.GetAll();
        }
        [HttpGet]
        public Product GetProduct(int id)
        {
            return mydata.Get(id);
        }
        [HttpPost]
        public Product CreateProduct(Product item)
        {
            return mydata.Add(item);
        }
        [HttpPut]
        public bool UpdateProduct(Product item)
        {
            return mydata.Update(item);
        }
        [HttpDelete]
        public void DeleteProduct(int id)
        {
            mydata.Delete(id);
        }
    }
}

