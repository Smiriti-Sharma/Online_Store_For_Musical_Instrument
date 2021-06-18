using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Online_Store_For_Musical_Instrument.Data;
using Online_Store_For_Musical_Instrument.Data.DataManager;
using Online_Store_For_Musical_Instrument.Models;
using Online_Store_For_Musical_Instrument.Data.Repository;


namespace Online_Store_For_Musical_Instrument.Controllers
{
    public class Products1Controller : ApiController
    {
        //private Online_Store_For_Musical_InstrumentContext db = new Online_Store_For_Musical_InstrumentContext();

        // GET: api/Products1

        IDataRepository mydata = ProductManager.getRepository();
            [System.Web.Http.HttpGet]
            public IEnumerable<Product> GetAllProduct()
            {
                return mydata.GetAll();
            }
            [System.Web.Http.HttpGet]
            public Product GetProduct(int id)
            {
                return mydata.Get(id);
            }
            [System.Web.Http.HttpPost]
            public Product Create(Product item)
            {
                return mydata.Add(item);
            }
            [System.Web.Http.HttpPut]
            public bool Update(Product item)
            {
                return mydata.Update(item);
            }
            [System.Web.Http.HttpDelete]
            public void Delete(int id)
            {
                mydata.Delete(id);
            }
        }
    }