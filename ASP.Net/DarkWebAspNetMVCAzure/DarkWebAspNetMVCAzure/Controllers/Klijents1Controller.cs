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
using DarkWebAspNetMVCAzure.Models;

namespace DarkWebAspNetMVCAzure.Controllers
{
    public class Klijents1Controller : ApiController
    {
        private DarkwebContext db = new DarkwebContext();

        // GET: api/Klijents1
        public IQueryable<Klijent> GetKlijent()
        {
            return db.Klijent;
        }

        // GET: api/Klijents1/5
        [ResponseType(typeof(Klijent))]
        public IHttpActionResult GetKlijent(string id)
        {
            Klijent klijent = db.Klijent.Find(id);
            if (klijent == null)
            {
                return NotFound();
            }

            return Ok(klijent);
        }

        // PUT: api/Klijents1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKlijent(string id, Klijent klijent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != klijent.tajniKod)
            {
                return BadRequest();
            }

            db.Entry(klijent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KlijentExists(id))
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

        // POST: api/Klijents1
        [ResponseType(typeof(Klijent))]
        public IHttpActionResult PostKlijent(Klijent klijent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Klijent.Add(klijent);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (KlijentExists(klijent.tajniKod))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = klijent.tajniKod }, klijent);
        }

        // DELETE: api/Klijents1/5
        [ResponseType(typeof(Klijent))]
        public IHttpActionResult DeleteKlijent(string id)
        {
            Klijent klijent = db.Klijent.Find(id);
            if (klijent == null)
            {
                return NotFound();
            }

            db.Klijent.Remove(klijent);
            db.SaveChanges();

            return Ok(klijent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KlijentExists(string id)
        {
            return db.Klijent.Count(e => e.tajniKod == id) > 0;
        }
    }
}