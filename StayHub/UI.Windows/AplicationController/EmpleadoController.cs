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
    public class EmpleadoController
    {
        //Accedemos al servico
        private EmpleadoServices servicioEmpleado;
        public EmpleadoController()
        {
            servicioEmpleado = new EmpleadoServices();

        }

        //Insertar
        public bool InsertarEmpleado(EmpleadoViewModel nuevoEmpleadoViewModel)
        {
            empleado nuevoEmpleado = new empleado();
            try
            {
                nuevoEmpleado.nombre_empleado = nuevoEmpleadoViewModel.Nombre_empleado;
                nuevoEmpleado.apellido_empleado = nuevoEmpleadoViewModel.Apellido_empleado;
                nuevoEmpleado.direccion_empleado = nuevoEmpleadoViewModel.Direccion_empleado;
                nuevoEmpleado.telefono_empleado = nuevoEmpleadoViewModel.Telefono_empleado;
                nuevoEmpleado.email_empleado = nuevoEmpleadoViewModel.Email_empleado;
                nuevoEmpleado.observaciones_empleado = nuevoEmpleadoViewModel.Observaciones_empleado;
                nuevoEmpleado.estado_empleado = nuevoEmpleadoViewModel.Estado_empleado;
                servicioEmpleado.InsertarEmpleadoHub(nuevoEmpleado);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar registro: "+ex.Message);
            }
        }

        //Modificar
        public bool ActualizarEmpleado(EmpleadoViewModel nuevoEmpleadoViewModel)
        {
            empleado nuevoEmpleado = new empleado();
            try
            {
                nuevoEmpleado.id_empleado = nuevoEmpleadoViewModel.Id_empleado;
                nuevoEmpleado.nombre_empleado = nuevoEmpleadoViewModel.Nombre_empleado;
                nuevoEmpleado.apellido_empleado = nuevoEmpleadoViewModel.Apellido_empleado;
                nuevoEmpleado.direccion_empleado = nuevoEmpleadoViewModel.Direccion_empleado;
                nuevoEmpleado.telefono_empleado = nuevoEmpleadoViewModel.Telefono_empleado;
                nuevoEmpleado.email_empleado = nuevoEmpleadoViewModel.Email_empleado;
                nuevoEmpleado.observaciones_empleado = nuevoEmpleadoViewModel.Observaciones_empleado;
                nuevoEmpleado.estado_empleado = nuevoEmpleadoViewModel.Estado_empleado;
                servicioEmpleado.ActualizarEmpleadoHub(nuevoEmpleado);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar registro: " + ex.Message);
            }
        }

        //Enlistar
        public IEnumerable<EmpleadoViewModel> ListarEmpleados()
        {
            var listaEmpleado = servicioEmpleado.GetEmpleadoHub(); //var almacena una lista, un bool, cualqueri cosa. Luego consume el servicio de GetEmpleados()
            List<EmpleadoViewModel> resultado = new List<EmpleadoViewModel>(); //Transformar para enviar la información al formulario
            try
            {
                foreach (empleado item in listaEmpleado)
                {
                    resultado.Add(new EmpleadoViewModel
                    {
                        Id_empleado = item.id_empleado,
                        Nombre_empleado = item.nombre_empleado,
                        Apellido_empleado = item.apellido_empleado,
                        Direccion_empleado=item.direccion_empleado,
                        Telefono_empleado = item.telefono_empleado,
                        Email_empleado = item.email_empleado,
                        Observaciones_empleado = item.observaciones_empleado,
                        Estado_empleado = item.estado_empleado,
                        //Mostrar columna de nombre completo (nuevo campo)
                        Nombre_Completo = item.nombre_empleado + " " + item.apellido_empleado,
                    });
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer registros: " + ex.Message);
            }
           
        }


        //Enlistar Activos
        public IEnumerable<EmpleadoViewModel> ListarEmpleadosActivos()
        {
            var listaEmpleado = servicioEmpleado.GetAllActivos(); //var almacena una lista, un bool, cualqueri cosa. Luego consume el servicio de GetEmpleados()
            List<EmpleadoViewModel> resultado = new List<EmpleadoViewModel>(); //Transformar para enviar la información al formulario
            try
            {
                foreach (empleado item in listaEmpleado)
                {
                    resultado.Add(new EmpleadoViewModel
                    {
                        Id_empleado = item.id_empleado,
                        Nombre_empleado = item.nombre_empleado,
                        Apellido_empleado = item.apellido_empleado,
                        Telefono_empleado = item.telefono_empleado,
                        Direccion_empleado=item.direccion_empleado,
                        Email_empleado = item.email_empleado,
                        Observaciones_empleado = item.observaciones_empleado,
                        Estado_empleado = item.estado_empleado,
                        //Agregamos para el combobox
                        Nombre_Completo = item.nombre_empleado + " " + item.apellido_empleado

                    });
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer registros activos: " + ex.Message);
            }

        }


    }
}
