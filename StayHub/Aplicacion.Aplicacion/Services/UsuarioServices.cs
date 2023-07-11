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
    public class UsuarioServices
    {
        //Instanciar interfa
        readonly IUsuarioRepository usuarioHub;

        //creamos el constructor:
        public UsuarioServices()
        {
            usuarioHub = new UsuarioRepository();
        }
        //metodo get:
       public IEnumerable<usuario> GetUsuarioHub()
        {
            return usuarioHub.GetAll();
        }
        //Metodo Post
        public void InsertarUsuarioHub(usuario nuevaUsuario)
        {
            usuarioHub.Add(nuevaUsuario);
        }
        //Metodo Put
        public void ActualizarUsuarioHub(usuario nuevaUsuario)
        {
            usuarioHub.Modify(nuevaUsuario);
        }
        //Metodo Delete
        public void EliminarUsuarioHub(int id)
        {
            usuarioHub.Delete(id);
        }

    }
}
