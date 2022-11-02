using sc601_caso3.Models.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using sc601_caso3.Models.Modelos;

namespace sc601_caso3.Controllers
{
    public class VehiculosController : ApiController
    {
        VehiculoModel vModel = new VehiculoModel();
        [HttpGet]
        [Route("api/Vehiculos/ListarVehiculos")]
        public IHttpActionResult ListarVehiculos()
        {
            try
            {
                List<VehiculoObj> resultado = vModel.ListarVehiculos();
                if(resultado.Count == 0)
                {
                    return Ok("No hay vehiculos registrados.");
                }
                return Ok(resultado);
            }
            catch (Exception)
            {
                Exception ex = new Exception("Error de base de datos. Contacte al administrador.");
                return InternalServerError(ex);
            }

        }

        [HttpGet]
        [Route("api/Vehiculos/VehiculoPlaca")]
        public IHttpActionResult ConsultarPlaca(string placa)
        {

            try
            {
                VehiculoObj resultado = vModel.ConsultarPlaca(placa);
                if (resultado == null)
                {
                    return BadRequest("No hay vehiculos registrados con la placa consultada.");
                }
                return Ok(resultado);
            }
            catch (Exception)
            {
                Exception ex = new Exception("Error de base de datos. Contacte al administrador.");
                return InternalServerError(ex);
            }

        }
    }
}