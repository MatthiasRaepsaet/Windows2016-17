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
using BackendApplication.Models;

namespace BackendApplication.Controllers
{
    public class OpleidingsController : ApiController
    {
        private BackendApplicationContext db = new BackendApplicationContext();

        // GET: api/Opleidings
        public IQueryable<Opleiding> GetOpleidings()
        {
            return db.Opleidings;
        }

        // GET: api/Opleidings/5
        [ResponseType(typeof(Opleiding))]
        public IHttpActionResult GetOpleiding(int id)
        {
            Opleiding opleiding = db.Opleidings.Find(id);
            if (opleiding == null)
            {
                return NotFound();
            }

            return Ok(opleiding);
        }

        // PUT: api/Opleidings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOpleiding(int id, Opleiding opleiding)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != opleiding.Id)
            {
                return BadRequest();
            }

            db.Entry(opleiding).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpleidingExists(id))
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

        // POST: api/Opleidings
        [ResponseType(typeof(Opleiding))]
        public IHttpActionResult PostOpleiding(Opleiding opleiding)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Opleidings.Add(opleiding);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = opleiding.Id }, opleiding);
        }

        // DELETE: api/Opleidings/5
        [ResponseType(typeof(Opleiding))]
        public IHttpActionResult DeleteOpleiding(int id)
        {
            Opleiding opleiding = db.Opleidings.Find(id);
            if (opleiding == null)
            {
                return NotFound();
            }

            db.Opleidings.Remove(opleiding);
            db.SaveChanges();

            return Ok(opleiding);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OpleidingExists(int id)
        {
            return db.Opleidings.Count(e => e.Id == id) > 0;
        }
    }
}