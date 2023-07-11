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
    public class HabitacionController
    {

        private HabitacionServices servicioHabitacion;

        //Constructor
        public HabitacionController()
        {
            servicioHabitacion = new HabitacionServices();
        }

        //Insertar
        public bool InsertarHabitacion(HabitacionViewModel nuevaHabitacionViewModel)
        {
            habitacion nuevaHabitacion = new habitacion();
            try
            {
                nuevaHabitacion.numero_habitacion = nuevaHabitacionViewModel.Numero_habitacion;
                nuevaHabitacion.piso_habitacion = nuevaHabitacionViewModel.Piso_habitacion;
                nuevaHabitacion.preciodiario_habitacion = nuevaHabitacionViewModel.Preciodiario_habitacion;
                nuevaHabitacion.tipo_habitacion = nuevaHabitacionViewModel.Tipo_habitacion;
                nuevaHabitacion.caracteristicas_habitacion = nuevaHabitacionViewModel.Caracteristicas_habitacion;
                nuevaHabitacion.estado_habitacion = nuevaHabitacionViewModel.Estado_habitacion;

                servicioHabitacion.InsertarHabitacionHub(nuevaHabitacion);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar registro: " + ex.Message);
            }
        }


        //Modificar
        public bool ModificarHabitacion(HabitacionViewModel nuevaHabitacionViewModel)
        {
            habitacion nuevaHabitacion = new habitacion();
            try
            {
                nuevaHabitacion.id_habitacion = nuevaHabitacionViewModel.Id_habitacion;
                nuevaHabitacion.numero_habitacion = nuevaHabitacionViewModel.Numero_habitacion;
                nuevaHabitacion.piso_habitacion = nuevaHabitacionViewModel.Piso_habitacion;
                nuevaHabitacion.preciodiario_habitacion = nuevaHabitacionViewModel.Preciodiario_habitacion;
                nuevaHabitacion.tipo_habitacion = nuevaHabitacionViewModel.Tipo_habitacion;
                nuevaHabitacion.caracteristicas_habitacion = nuevaHabitacionViewModel.Caracteristicas_habitacion;
                nuevaHabitacion.estado_habitacion = nuevaHabitacionViewModel.Estado_habitacion;

                servicioHabitacion.ActualizarHabitacionHub(nuevaHabitacion);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar registro: " + ex.Message);
            }
        }

        //GET ALL
        public IEnumerable<HabitacionViewModel> ListarHabitaciones()
        {
            var listaHabitaciones = servicioHabitacion.GetHabitacionHub(); //var almacena una lista, un bool, cualqueri cosa. Luego consume el servicio de GetEmpleados()
            List<HabitacionViewModel> resultado = new List<HabitacionViewModel>(); //Transformar para enviar la información al formulario
            try
            {
                foreach (habitacion item in listaHabitaciones)
                {
                    resultado.Add(new HabitacionViewModel
                    {
                        Id_habitacion = item.id_habitacion,
                        Numero_habitacion = item.numero_habitacion,
                        Piso_habitacion = item.piso_habitacion,
                        Preciodiario_habitacion = item.preciodiario_habitacion,
                        Tipo_habitacion = item.tipo_habitacion,
                        Caracteristicas_habitacion = item.caracteristicas_habitacion,
                        Estado_habitacion = item.estado_habitacion
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
