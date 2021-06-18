using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Online_Store_For_Musical_Instrument.Data;
using Online_Store_For_Musical_Instrument.Models;

namespace Online_Store_For_Musical_Instrument.Controllers
{
    public class OrderMastersController : ApiController
    {
        private Online_Store_For_Musical_InstrumentContext db = new Online_Store_For_Musical_InstrumentContext();

        // GET: api/OrderMasters
        public IQueryable<OrderMaster> GetOrderMasters()
        {
            return db.OrderMasters;
        }

        // GET: api/OrderMasters/5
        [ResponseType(typeof(OrderMaster))]
        public async Task<IHttpActionResult> GetOrderMaster(int id)
        {
            OrderMaster orderMaster = await db.OrderMasters.FindAsync(id);
            if (orderMaster == null)
            {
                return NotFound();
            }

            return Ok(orderMaster);
        }

        // PUT: api/OrderMasters/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOrderMaster(int id, OrderMaster orderMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orderMaster.OrderMasterID)
            {
                return BadRequest();
            }

            db.Entry(orderMaster).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderMasterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/OrderMasters
        [ResponseType(typeof(OrderMaster))]
        public async Task<IHttpActionResult> PostOrderMaster(OrderMaster orderMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OrderMasters.Add(orderMaster);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = orderMaster.OrderMasterID }, orderMaster);
        }

        // DELETE: api/OrderMasters/5
        [ResponseType(typeof(OrderMaster))]
        public async Task<IHttpActionResult> DeleteOrderMaster(int id)
        {
            OrderMaster orderMaster = await db.OrderMasters.FindAsync(id);
            if (orderMaster == null)
            {
                return NotFound();
            }

            db.OrderMasters.Remove(orderMaster);
            await db.SaveChangesAsync();

            return Ok(orderMaster);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderMasterExists(int id)
        {
            return db.OrderMasters.Count(e => e.OrderMasterID == id) > 0;
        }
    }
}