using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sc601_caso3.Models.Objetos
{
    public class CotizacionObj
    {
        public int codigo { get; set; } //PK
        [Required(ErrorMessage = "El campo matricula es requerido.")]
        public string matricula { get; set; } //FK
        [Required(ErrorMessage = "El campo porcentaje de descuento es requerido.")]
        [Range(1, 3, ErrorMessage = "El valor para {0} debe encontrarse entre {1} y {2}.")]
        public int porcentaje { get; set; } //Porcentaje de descuento
        public decimal precioFinal { get; set; } //Precio final de la cotización
    }
}