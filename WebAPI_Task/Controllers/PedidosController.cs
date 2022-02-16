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
using Api.Repository.Pedidos;
using Model;
using Model.Dto.Pedidos;

namespace WebAPI_Task.Controllers
{
    public class PedidosController : ApiController
    {
        private OraContext db = new OraContext();

        // GET: api/Pedidos
        public IQueryable<Pedidos> GetPedidos()
        {
            return db.Pedidos;
        }

        // GET: api/Pedidos/5
        [ResponseType(typeof(Pedidos))]
        public IHttpActionResult GetPedidos(int id)
        {
            Pedidos pedidos = db.Pedidos.Find(id);
            if (pedidos == null)
            {
                return NotFound();
            }

            return Ok(pedidos);
        }

        // PUT: api/Pedidos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPedidos(int id, Pedidos pedidos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pedidos.ID)
            {
                return BadRequest();
            }

            db.Entry(pedidos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidosExists(id))
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

        [HttpPost()]
        public IHttpActionResult PostPedidos([FromBody] IncluirPedidoDto pedido)
        {
            try
            {
                var unit = new IncluirPedidoUnitOfWork(db);

                var result = unit.IncluirPedido(pedido);

                return CreatedAtRoute("DefaultApi", new { id = result.ID }, result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/Pedidos/5
        [ResponseType(typeof(Pedidos))]
        public IHttpActionResult DeletePedidos(int id)
        {
            Pedidos pedidos = db.Pedidos.Find(id);
            if (pedidos == null)
            {
                return NotFound();
            }

            db.Pedidos.Remove(pedidos);
            db.SaveChanges();

            return Ok(pedidos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PedidosExists(int id)
        {
            return db.Pedidos.Count(e => e.ID == id) > 0;
        }
    }
}