using System;
using System.Web.Http;

namespace sc601_caso3.Controllers
{
    public class CotizacionesController : ApiController
    {
        //Método que recibe parametros y devuelve la cotización del vehículo dado.
        [HttpPost]
        public IHttpActionResult Index()
        {
            return Ok("Ok");
        }
    }
}