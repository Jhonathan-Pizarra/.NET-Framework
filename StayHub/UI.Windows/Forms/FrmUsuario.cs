using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.AplicationController;
using UI.Windows.ViewModel;

namespace UI.Windows.Forms
{
    public partial class FrmUsuario : Form
    {
        //
        private UsuarioController controllerUsuario;
        private UsuarioViewModel viewModelUsuario;

        public FrmUsuario()
        {
            InitializeComponent();
            controllerUsuario = new UsuarioController();
        }

        //Insertar Empleado
        public void Insertar()
        {
            if (controllerUsuario.InsertarUsuario(viewModelUsuario))
            {
                MessageBox.Show("Registro creado exitosamente!");
            }
            else
            {
                MessageBox.Show("Registro no se ha creado.");
            }
        }


        //Actualizar Empleado
        public void Actualizar()
        {
            if (controllerUsuario.ActualizarUsuario(viewModelUsuario))
            {
                MessageBox.Show("Registro modificado exitosamente!");
            }
            else
            {
                MessageBox.Show("Registro no se ha modificado.");
            }
        }

        //Limpiar inputs
        public void Limpiar()
        {
            txtID.Text = "";
            txtEmpleado.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEstado.Text = "";
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            viewModelUsuario = new UsuarioViewModel();
            viewModelUsuario.Id_empleado = int.Parse(txtEmpleado.Text);
            viewModelUsuario.Usuario1 = txtUsername.Text;
            viewModelUsuario.Contraseña = txtUsername.Text;
            viewModelUsuario.Estado = int.Parse(txtEstado.Text);

            //if para cualquier cosa que necesite controlar
            if (txtID.Text != "")
            {
                viewModelUsuario.Id_usuario = int.Parse(txtID.Text);
                Actualizar();
            }
            else
            {
                Insertar();
                Limpiar();
            }

        }
    }
}
