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
    public class CabeceraReservaServices
    {
        //Instanciamos la Interfaz
        readonly ICabeceraReservaRepository cabeceraReserva;

        //Método constructor
        public CabeceraReservaServices()
        {
            cabeceraReserva = new CabeceraReservaRepository();
        }

        //Metdo Get
        public IEnumerable<cabecera_reserva> GetCabeceraReserva()
        {
            return cabeceraReserva.GetAll();
        }

        //Metodo Post
        public void InsertarCabeceraReserva(cabecera_reserva nuevaCabeceraReserva)
        {
            cabeceraReserva.Add(nuevaCabeceraReserva);
        }

        //Metodo Put
        public void ActualizarCabeceraReserva(cabecera_reserva nuevaCabeceraReserva)
        {
            cabeceraReserva.Modify(nuevaCabeceraReserva);
        }

        //Metodo Delete
        public void EliminarCabeceraReserva(int id)
        {
            cabeceraReserva.Delete(id);
        }
    }
}
