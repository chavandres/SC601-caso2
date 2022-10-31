using sc601_caso3.BaseDatos;
using sc601_caso3.Models.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sc601_caso3.Models.Modelos
{
    public class CotizacionModel
    {
        public CotizacionObj CotizarVehiculo(CotizacionObj cot) {
            using (var conn = new PracticaLNEntities()) {
                var resultado = conn.CotizacionVehiculo(cot.matricula, cot.porcentaje).FirstOrDefault();
                if (resultado != null) {
                    cot.codigo = resultado.Codigo;
                    cot.precioFinal = resultado.PrecioFinal;
                }
                else {
                    cot.precioFinal = 0;
                }
            }
            return cot;
        }
    }
}