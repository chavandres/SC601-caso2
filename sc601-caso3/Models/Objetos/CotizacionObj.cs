using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sc601_caso3.Models.Objetos
{
    public class CotizacionObj
    {
        public int codigo { get; set; }
        public string matricula { get; set; }  
        public int porcentaje { get; set; }
        public decimal precioFinal { get; set; }
    }
}