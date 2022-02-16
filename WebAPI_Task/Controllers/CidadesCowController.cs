using CacheCow.Server.WebApi;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI_Task.Models;

namespace WebAPI_Task.Controllers
{
    public class CidadesCowController : ApiController
    {

        [HttpGet]
        [HttpCache(DefaultExpirySeconds = 300)]
        public IEnumerable<CidadesDTO> GetAllCities()
        {
            return CidadesTable.CidadesList.ToList();
        }

        [HttpGet]
        [HttpCache(DefaultExpirySeconds = 300)]
        public CidadesDTO Get(int id)
        {
            return GetAllCities().Where(c=> c.Id == id).FirstOrDefault();
        }

    }
}
