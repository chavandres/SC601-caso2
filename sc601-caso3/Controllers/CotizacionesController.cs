using sc601_caso3.Models.Modelos;
using sc601_caso3.Models.Objetos;
using System;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace sc601_caso3.Controllers
{
    public class CotizacionesController : ApiController
    {
        CotizacionModel cotModel = new CotizacionModel();
        //Método que recibe parametros y devuelve la cotización del vehículo dado.
        [HttpPost]
        public IHttpActionResult Index(CotizacionObj cot)
        {
            if (!ModelState.IsValid) { //Validar los datos enviados por el usuario
                String msg = "";
                foreach (ModelState modelState in ModelState.Values) {
                    foreach (ModelError error in modelState.Errors) {
                        msg += error.ErrorMessage;
                    }
                }
                return BadRequest(msg);
            }

            cotModel.CotizarVehiculo(cot);
            if (cot.precioFinal == 0) {
                return BadRequest("El vehículo es del año 2010 o antes y por ende no puede ser cotizado.");
            }

            return Ok(cot);
        }
    }
}