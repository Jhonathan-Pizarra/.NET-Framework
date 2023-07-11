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
    public class UsuarioController
    {
        private UsuarioServices servicioUsuario;

        //Constructor
        public UsuarioController()
        {
            servicioUsuario = new UsuarioServices();
        }

        //Insertar
        public bool InsertarUsuario(UsuarioViewModel nuevoUsuarioViewModel)
        {
            usuario nuevoUsuario = new usuario();
            try
            {
                nuevoUsuario.id_empleado = nuevoUsuarioViewModel.Id_empleado;
                nuevoUsuario.usuario1 = nuevoUsuarioViewModel.Usuario1;  //username
                nuevoUsuario.contraseña = nuevoUsuarioViewModel.Contraseña;
                nuevoUsuario.estado = nuevoUsuarioViewModel.Estado;

                servicioUsuario.InsertarUsuarioHub(nuevoUsuario);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar registro: " + ex.Message);
            }
        }

        //Modificar
        public bool ActualizarUsuario(UsuarioViewModel nuevoUsuarioViewModel)
        {
            usuario nuevoUsuario = new usuario();
            try
            {
                nuevoUsuario.id_usuario = nuevoUsuarioViewModel.Id_usuario;
                nuevoUsuario.id_empleado = nuevoUsuarioViewModel.Id_empleado;
                nuevoUsuario.usuario1 = nuevoUsuarioViewModel.Usuario1;  //username
                nuevoUsuario.contraseña = nuevoUsuarioViewModel.Contraseña;
                nuevoUsuario.estado = nuevoUsuarioViewModel.Estado;

                servicioUsuario.ActualizarUsuarioHub(nuevoUsuario);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar registro: " + ex.Message);
            }
        }

        //GET ALL
        public IEnumerable<UsuarioViewModel> ListarUsuarios()
        {
            var listaUsuarios = servicioUsuario.GetUsuarioHub(); //var almacena una lista, un bool, cualqueri cosa. Luego consume el servicio de GetEmpleados()
            List<UsuarioViewModel> resultado = new List<UsuarioViewModel>(); //Transformar para enviar la información al formulario
            try
            {
                foreach (usuario item in listaUsuarios)
                {
                    resultado.Add(new UsuarioViewModel
                    {
                        Id_usuario = item.id_usuario,
                        Id_empleado = item.id_empleado,
                        Usuario1 = item.usuario1,
                        Contraseña = item.contraseña,
                        Estado = item.estado,
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
