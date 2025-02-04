﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sc601_caso3.BaseDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PracticaLNEntities : DbContext
    {
        public PracticaLNEntities()
            : base("name=PracticaLNEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<CotizacionVehiculo_Result> CotizacionVehiculo(string matricula, Nullable<int> porcentaje)
        {
            var matriculaParameter = matricula != null ?
                new ObjectParameter("Matricula", matricula) :
                new ObjectParameter("Matricula", typeof(string));
    
            var porcentajeParameter = porcentaje.HasValue ?
                new ObjectParameter("Porcentaje", porcentaje) :
                new ObjectParameter("Porcentaje", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CotizacionVehiculo_Result>("CotizacionVehiculo", matriculaParameter, porcentajeParameter);
        }
    
        public virtual ObjectResult<ConsultaVehiculoPlaca_Result> ConsultaVehiculoPlaca(string placa)
        {
            var placaParameter = placa != null ?
                new ObjectParameter("placa", placa) :
                new ObjectParameter("placa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultaVehiculoPlaca_Result>("ConsultaVehiculoPlaca", placaParameter);
        }
    
        public virtual ObjectResult<ListarVehiculos_Result> ListarVehiculos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarVehiculos_Result>("ListarVehiculos");
        }
    
        public virtual int RegistroBitacora(Nullable<long> codigoCotizacion)
        {
            var codigoCotizacionParameter = codigoCotizacion.HasValue ?
                new ObjectParameter("CodigoCotizacion", codigoCotizacion) :
                new ObjectParameter("CodigoCotizacion", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistroBitacora", codigoCotizacionParameter);
        }
    }
}
