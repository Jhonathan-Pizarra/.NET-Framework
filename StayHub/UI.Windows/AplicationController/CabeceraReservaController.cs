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
    public class CabeceraReservaController
    {
        private CabeceraReservaServices servicioCabecera;

        public CabeceraReservaController()
        {
            servicioCabecera = new CabeceraReservaServices();
        }

        //Insertar
        public bool InsertarCabeceraReserva(CabeceraReservaViewModel nuevaCabeceraViewModel)
        {
            cabecera_reserva nuevaReserva = new cabecera_reserva();
            try
            {
                nuevaReserva.id_cliente = nuevaCabeceraViewModel.Id_cliente;
                nuevaReserva.id_usuario = nuevaCabeceraViewModel.Id_usuario;
                nuevaReserva.fecha_reserva = nuevaCabeceraViewModel.Fecha_reserva;
                nuevaReserva.fecha_entrada = nuevaCabeceraViewModel.Fecha_entrada;
                nuevaReserva.fecha_salida = nuevaCabeceraViewModel.Fecha_salida;
                nuevaReserva.estado_reserva = nuevaCabeceraViewModel.Estado_reserva;
                nuevaReserva.observaciones = nuevaCabeceraViewModel.Observaciones;

                servicioCabecera.InsertarCabeceraReserva(nuevaReserva);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar registro: " + ex.Message);
            }
        }


        //Modificar
        public bool ActualizarCabeceraReserva(CabeceraReservaViewModel nuevaCabeceraViewModel)
        {
            cabecera_reserva nuevaReserva = new cabecera_reserva();
            try
            {
                nuevaReserva.id_reserva = nuevaCabeceraViewModel.Id_reserva;
                nuevaReserva.id_cliente = nuevaCabeceraViewModel.Id_cliente;
                nuevaReserva.id_usuario = nuevaCabeceraViewModel.Id_usuario;
                nuevaReserva.fecha_reserva = nuevaCabeceraViewModel.Fecha_reserva;
                nuevaReserva.fecha_entrada = nuevaCabeceraViewModel.Fecha_entrada;
                nuevaReserva.fecha_salida = nuevaCabeceraViewModel.Fecha_salida;
                nuevaReserva.estado_reserva = nuevaCabeceraViewModel.Estado_reserva;
                nuevaReserva.observaciones = nuevaCabeceraViewModel.Observaciones;

                servicioCabecera.ActualizarCabeceraReserva(nuevaReserva);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar registro: " + ex.Message);
            }
        }

        //GET ALL
        public IEnumerable<CabeceraReservaViewModel> ListarReservas()
        {
            var listaReservas = servicioCabecera.GetCabeceraReserva(); //var almacena una lista, un bool, cualqueri cosa. Luego consume el servicio de GetEmpleados()
            List<CabeceraReservaViewModel> resultado = new List<CabeceraReservaViewModel>(); //Transformar para enviar la información al formulario
            try
            {
                foreach (cabecera_reserva item in listaReservas)
                {
                    resultado.Add(new CabeceraReservaViewModel
                    {
                        Id_reserva = item.id_reserva,
                        Id_cliente = item.id_cliente,
                        Id_usuario = item.id_usuario,
                        Fecha_reserva = item.fecha_reserva,
                        Fecha_entrada = item.fecha_entrada,
                        Fecha_salida = item.fecha_salida,
                        Estado_reserva = item.estado_reserva,
                        Observaciones = item.observaciones,
                  
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
