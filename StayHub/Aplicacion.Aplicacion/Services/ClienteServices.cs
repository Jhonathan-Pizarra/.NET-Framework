using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Aplicacion.Services
{
    public class ClienteServices
    {
        //Instanciamos la Interfaz
        readonly IClienteRepository clienteStayHub;

        //Constructor
        public ClienteServices()
        {
            clienteStayHub = new ClienteRepository();
        }
       //Metodo get:
       public IEnumerable<cliente> GetClienteHub()
        {
            return clienteStayHub.GetAll();
        }
        //Metodo Post
        public void InsertarClienteHub(cliente nuevoCliente)
        {
            clienteStayHub.Add(nuevoCliente);
        }
        //Metodo Put
        public void ActualizarClienteHub(cliente nuevoCliente)
        {
            clienteStayHub.Modify(nuevoCliente);
        }
        //Metodo Delete
        public void EliminarClienteHub(int id)
        {
            clienteStayHub.Delete(id);
        }
    }
}
