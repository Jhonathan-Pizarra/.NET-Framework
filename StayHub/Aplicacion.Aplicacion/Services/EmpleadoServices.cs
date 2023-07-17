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
    public class EmpleadoServices
    {
        //Instanciamos la Interfaz
        readonly IEmpleadoRepository empleadoHub;

        //Constructor:
        public EmpleadoServices()
        {
            empleadoHub = new EmpleadoRepository();
        }
        //Get
        public IEnumerable<empleado> GetEmpleadoHub()
        {
            return empleadoHub.GetAll();
        }
        //Metodo Post
        public void InsertarEmpleadoHub(empleado nuevoEmpleado)
        {
            empleadoHub.Add(nuevoEmpleado);
        }
        //Metodo Put
        public void ActualizarEmpleadoHub(empleado nuevoEmpleado)
        {
            empleadoHub.Modify(nuevoEmpleado);
        }
        //Metodo Delete
        public void EliminarEmpleadoHub(int id)
        {
            empleadoHub.Delete(id);
        }

        //Personalziados
        public IEnumerable<empleado> GetAllActivos()
        {
            //retorna solo los activos
            return empleadoHub.GetAllActivos();
        }

    }
}
