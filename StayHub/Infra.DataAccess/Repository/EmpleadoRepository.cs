using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class EmpleadoRepository : BaseRepository<empleado>, IEmpleadoRepository
    {
        public IEnumerable<empleado> GetAllActivos()
        {
            try
            {
                //Conexion a la base de datos
                using (var context = new StayHubEntities())
                {
                    //Instrucción para hacer el select personalizado
                    var resultadoEmpleados = from e in context.empleado
                                         where e.estado_empleado == 1
                                         select e;
                    return resultadoEmpleados.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar (Repository)" + ex.Message);
            }
        }
    }
}
