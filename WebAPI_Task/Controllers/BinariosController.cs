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
    public class BinariosController : ApiController
    {
        private OraContext db = new OraContext();

        // GET: api/Binarios
        public IQueryable<Binarios> GetBinarios()
        {
            return db.Binarios;
        }

        // GET: api/Binarios/5
        [ResponseType(typeof(Binarios))]
        public IHttpActionResult GetBinarios(int id)
        {
            Binarios binarios = db.Binarios.Find(id);
            if (binarios == null)
            {
                return NotFound();
            }

            return Ok(binarios);
        }

        // PUT: api/Binarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBinarios(int id, Binarios binarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != binarios.ID)
            {
                return BadRequest();
            }

            db.Entry(binarios).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BinariosExists(id))
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

        // POST: api/Binarios
        [ResponseType(typeof(Binarios))]
        public IHttpActionResult PostBinarios(Binarios binarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Binarios.Add(binarios);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = binarios.ID }, binarios);
        }

        // DELETE: api/Binarios/5
        [ResponseType(typeof(Binarios))]
        public IHttpActionResult DeleteBinarios(int id)
        {
            Binarios binarios = db.Binarios.Find(id);
            if (binarios == null)
            {
                return NotFound();
            }

            db.Binarios.Remove(binarios);
            db.SaveChanges();

            return Ok(binarios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BinariosExists(int id)
        {
            return db.Binarios.Count(e => e.ID == id) > 0;
        }
    }
}