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
    public class HabitacionServices
    {
        //Instanciamos Interfaz
        readonly IHabitacionRepository habitacionHub;

        //creamos el constructor:
        public HabitacionServices()
        {
            habitacionHub = new HabitacionRepository();
        }
        // Metodo get:
       public IEnumerable<habitacion> GetHabitacionHub()
        {
            return habitacionHub.GetAll();
        }
        //Metodo Post
        public void InsertarHabitacionHub(habitacion nuevaHabitacion)
        {
            habitacionHub.Add(nuevaHabitacion);
        }
        //Metodo Put
        public void ActualizarHabitacionHub(habitacion nuevaHabitacion)
        {
            habitacionHub.Modify(nuevaHabitacion);
        }
        //Metodo Delete
        public void EliminarHabitacionHub(int id)
        {
            habitacionHub.Delete(id);
        }


    }
}
