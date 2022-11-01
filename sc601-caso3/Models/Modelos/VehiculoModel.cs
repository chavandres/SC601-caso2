using sc601_caso3.BaseDatos;
using sc601_caso3.Models.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sc601_caso3.Models.Modelos
{
    public class VehiculoModel
    {

        public List<VehiculoObj> ListarVehiculos()
        {
            using (var conn = new PracticaLNEntities())
            {
                var resultado = conn.ListarVehiculos();
                List<VehiculoObj> vehiculos = new List<VehiculoObj>();

                foreach (var vehiculo in resultado)
                {
                    vehiculos.Add(new VehiculoObj
                    {
                        matricula = vehiculo.Matricula,
                        precioInicial = vehiculo.PrecioInicial,
                        fabricacion = vehiculo.Fabricacion,
                    });
                }
            
                return vehiculos;
            }

        }

        public VehiculoObj ConsultarPlaca(string placa)
        {
            using (var conn = new PracticaLNEntities())
            {
                var resultado = conn.ConsultaVehiculoPlaca(placa).FirstOrDefault();
                if(resultado == null)
                {
                    return null;
                }
                else
                { 
                    VehiculoObj vehiculoEncontrado = new VehiculoObj();

                    vehiculoEncontrado.matricula = resultado.Matricula;
                    vehiculoEncontrado.precioInicial = resultado.PrecioInicial;
                    vehiculoEncontrado.fabricacion = resultado.Fabricacion;

                    return vehiculoEncontrado;
                };

            }   


        }



    }
}