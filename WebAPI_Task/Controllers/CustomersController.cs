using System.Web.Http;
using WebAPI_Task.Models;

namespace WebAPI_Task.Controllers
{
    public class CustomersController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Json(CustomersDB.CustomersList);
        }
        
    }
}
