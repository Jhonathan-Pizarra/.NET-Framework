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
    public class DetalleReservaServices
    {
        //Instanciamos la Interfaz
        readonly IDetalleReservaRepository detalleReserva;

        //Constructor
        public DetalleReservaServices()
        {
            detalleReserva = new DetalleReservaRepository();
        }

        //Metodo Get
        public IEnumerable<detalle_reserva> GetDetalleReserva()
        {
            return detalleReserva.GetAll();
        }
        //Metodo Post
        public void InsertarDetalleReserva(detalle_reserva nuevoDetalleReserva)
        {
            detalleReserva.Add(nuevoDetalleReserva);
        }
        //Metodo Put
        public void ActualizarDetalleReserva(detalle_reserva nuevoDetalleReserva)
        {
            detalleReserva.Modify(nuevoDetalleReserva);
        }
        //Metodo Delete
        public void EliminarDetalleReserva(int id)
        {
            detalleReserva.Delete(id);
        }
    }
}
