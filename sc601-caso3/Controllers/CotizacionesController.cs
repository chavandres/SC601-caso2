using sc601_caso3.Models.Objetos;
using System;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace sc601_caso3.Controllers
{
    public class CotizacionesController : ApiController
    {
        //Método que recibe parametros y devuelve la cotización del vehículo dado.
        [HttpPost]
        public IHttpActionResult Index(CotizacionObj cot)
        {
            if (!ModelState.IsValid) {
                String msg = "";
                foreach (ModelState modelState in ModelState.Values) {
                    foreach (ModelError error in modelState.Errors) {
                        msg += error.ErrorMessage;
                    }
                }
                return BadRequest(msg);
            }
            return Ok(cot);
        }
    }
}