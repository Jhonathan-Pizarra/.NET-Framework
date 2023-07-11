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
    public class ClienteController
    {
        //InstanciarServicio
        private ClienteServices servicioCliente;

        //Constructor
        public ClienteController()
        {
            servicioCliente = new ClienteServices();
        }

        //Insertar
        public bool InsertarCliente(ClienteViewModel nuevoClienteViewModel)
        {
            cliente nuevoCliente = new cliente();
            try
            {
                nuevoCliente.identificacion_cliente = nuevoClienteViewModel.Identificacion_cliente;
                nuevoCliente.nombre_cliente = nuevoClienteViewModel.Nombre_cliente;
                nuevoCliente.apellido_cliente = nuevoClienteViewModel.Apellido_cliente;
                nuevoCliente.direccion_cliente = nuevoClienteViewModel.Direccion_cliente;
                nuevoCliente.telefono_cliente = nuevoClienteViewModel.Telefono_cliente;
                nuevoCliente.email_cliente = nuevoClienteViewModel.Email_cliente;
                nuevoCliente.estado_cliente = nuevoClienteViewModel.Estado_cliente;
                servicioCliente.InsertarClienteHub(nuevoCliente);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar registro: " + ex.Message);
            }
        }

        //Modificar
        public bool ActualizarCliente(ClienteViewModel nuevoClienteViewModel)
        {
            cliente nuevoCliente = new cliente();
            try
            {
                nuevoCliente.id_cliente = nuevoClienteViewModel.Id_cliente;
                nuevoCliente.identificacion_cliente = nuevoClienteViewModel.Identificacion_cliente;
                nuevoCliente.nombre_cliente = nuevoClienteViewModel.Nombre_cliente;
                nuevoCliente.apellido_cliente = nuevoClienteViewModel.Apellido_cliente;
                nuevoCliente.direccion_cliente = nuevoClienteViewModel.Direccion_cliente;
                nuevoCliente.telefono_cliente = nuevoClienteViewModel.Telefono_cliente;
                nuevoCliente.email_cliente = nuevoClienteViewModel.Email_cliente;
                nuevoCliente.estado_cliente = nuevoClienteViewModel.Estado_cliente;
                servicioCliente.ActualizarClienteHub(nuevoCliente);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar registro: " + ex.Message);
            }
        }

        //GET ALL
        public IEnumerable<ClienteViewModel> ListarClientes()
        {
            var listaCliente = servicioCliente.GetClienteHub(); //var almacena una lista, un bool, cualqueri cosa. Luego consume el servicio de GetEmpleados()
            List<ClienteViewModel> resultado = new List<ClienteViewModel>(); //Transformar para enviar la información al formulario
            try
            {
                foreach (cliente item in listaCliente)
                {
                    resultado.Add(new ClienteViewModel
                    {
                        Id_cliente = item.id_cliente,
                        Identificacion_cliente = item.identificacion_cliente,
                        Nombre_cliente = item.nombre_cliente,
                        Apellido_cliente = item.apellido_cliente,
                        Direccion_cliente = item.direccion_cliente,
                        Telefono_cliente = item.telefono_cliente,
                        Email_cliente = item.email_cliente,
                        Estado_cliente = item.estado_cliente
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
