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
using Api.Repository;
using Model;

namespace WebAPI_Task.Controllers
{
    public class AnexosController : ApiController
    {
        private OraContext db = new OraContext();

        // GET: api/Anexos
        public IQueryable<Anexos> GetAnexos()
        {
            return db.Anexos;
        }

        // GET: api/Anexos/5
        [ResponseType(typeof(Anexos))]
        public IHttpActionResult GetAnexos(int id)
        {
            Anexos anexos = db.Anexos.Find(id);
            if (anexos == null)
            {
                return NotFound();
            }

            return Ok(anexos);
        }

        // PUT: api/Anexos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAnexos(int id, Anexos anexos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != anexos.ID)
            {
                return BadRequest();
            }

            db.Entry(anexos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnexosExists(id))
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

        // POST: api/Anexos
        [ResponseType(typeof(Anexos))]
        public IHttpActionResult PostAnexos(Anexos anexos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Anexos.Add(anexos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = anexos.ID }, anexos);
        }

        // DELETE: api/Anexos/5
        [ResponseType(typeof(Anexos))]
        public IHttpActionResult DeleteAnexos(int id)
        {
            Anexos anexos = db.Anexos.Find(id);
            if (anexos == null)
            {
                return NotFound();
            }

            db.Anexos.Remove(anexos);
            db.SaveChanges();

            return Ok(anexos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AnexosExists(int id)
        {
            return db.Anexos.Count(e => e.ID == id) > 0;
        }
    }
}