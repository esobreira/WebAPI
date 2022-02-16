using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web.Http;
using WebAPI_Task.Models;

namespace WebAPI_Task.Controllers
{
    public class CidadesController : ApiController
    {
        [HttpGet]
        [Route("cidades")]
        public IEnumerable<CidadesDTO> Get()
        {
            ObjectCache cache = MemoryCache.Default;

            IReadOnlyCollection<CidadesDTO> cidades = cache.Get("lista_full_cidades") as IReadOnlyCollection<CidadesDTO>;

            if (cidades != null)
                return cidades;

            cidades = CidadesTable.CidadesList;

            var policy = new CacheItemPolicy()
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(60),
            };

            cache.Add("lista_full_cidades", cidades, policy);

            return cidades;
        }

        [HttpGet]
        [Route("cidades_nocache")]
        public IEnumerable<CidadesDTO> GetNoCache()
        {
            return CidadesTable.CidadesList.ToList();
        }

        public CidadesDTO GetByID(int id)
        {
            return this.Get().Where(m => m.Id == id).FirstOrDefault();
        }
    }
}