using Aplicacion.Aplicacion.Services;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class DetalleReservaController
    {

        private DetalleReservaServices servicioDetalle;

        public DetalleReservaController()
        {
            servicioDetalle = new DetalleReservaServices();
        }

        //Insertar
        public bool InsertarDetalleReserva(DetalleReservaViewModel nuevoDetalleViewModel)
        {
            detalle_reserva nuevoDetalle = new detalle_reserva();
            try
            {
                nuevoDetalle.id_reserva = nuevoDetalleViewModel.Id_reserva;
                nuevoDetalle.id_habitacion = nuevoDetalleViewModel.Id_habitacion;
                nuevoDetalle.cantidad_personas = nuevoDetalleViewModel.Cantidad_dias;
                nuevoDetalle.cantidad_dias = nuevoDetalleViewModel.Cantidad_dias;
                nuevoDetalle.observaciones = nuevoDetalleViewModel.Observaciones;
                nuevoDetalle.estado = nuevoDetalleViewModel.Estado;
                servicioDetalle.InsertarDetalleReserva(nuevoDetalle);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar registro: " + ex.Message);
            }
        }


        //Modificar
        public bool ActualizarDetalleReserva(DetalleReservaViewModel nuevoDetalleViewModel)
        {
            detalle_reserva nuevoDetalle = new detalle_reserva();
            try
            {
                nuevoDetalle.id_detalle = nuevoDetalleViewModel.Id_detalle;
                nuevoDetalle.id_reserva = nuevoDetalleViewModel.Id_reserva;
                nuevoDetalle.id_habitacion = nuevoDetalleViewModel.Id_habitacion;
                nuevoDetalle.cantidad_personas = nuevoDetalleViewModel.Cantidad_dias;
                nuevoDetalle.cantidad_dias = nuevoDetalleViewModel.Cantidad_dias;
                nuevoDetalle.observaciones = nuevoDetalleViewModel.Observaciones;
                nuevoDetalle.estado = nuevoDetalleViewModel.Estado;
                servicioDetalle.ActualizarDetalleReserva(nuevoDetalle);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar registro: " + ex.Message);
            }
        }

        //GET ALL
        public IEnumerable<DetalleReservaViewModel> ListarReservas()
        {
            var listaReservas = servicioDetalle.GetDetalleReserva(); //var almacena una lista, un bool, cualqueri cosa. Luego consume el servicio de GetEmpleados()
            List<DetalleReservaViewModel> resultado = new List<DetalleReservaViewModel>(); //Transformar para enviar la información al formulario
            try
            {
                foreach (detalle_reserva item in listaReservas)
                {
                    resultado.Add(new DetalleReservaViewModel
                    {
                        Id_detalle = item.id_detalle,
                        Id_reserva = item.id_reserva,
                        Id_habitacion = item.id_habitacion,
                        Cantidad_dias = item.cantidad_dias,
                        Cantidad_personas = item.cantidad_personas,
                        Observaciones = item.observaciones,
                        Estado = item.estado,
                    });
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer registros: " + ex.Message);
            }

        }


    }
}
