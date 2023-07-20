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
    public partial class FrmCliente : Form
    {
        private ClienteController controllerCliente;
        private ClienteViewModel viewModelCliente;

        public FrmCliente()
        {
            InitializeComponent();
            controllerCliente = new ClienteController();
        }

        //Metodo Insertar
        public void Insertar()
        {
            if (controllerCliente.InsertarCliente(viewModelCliente))
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
            if (controllerCliente.ActualizarCliente(viewModelCliente))
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
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            chkEstado.Checked = false;
            //txtEstado.Text = "";
            txtDNI.Text = "";
        }

        public void ListarClientes()
        {
            dgvClientes.DataSource = controllerCliente.ListarClientes();

        }


        //Boton
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            viewModelCliente = new ClienteViewModel();
            viewModelCliente.Identificacion_cliente = txtDNI.Text;
            viewModelCliente.Nombre_cliente = txtNombre.Text;
            viewModelCliente.Apellido_cliente = txtApellido.Text;
            viewModelCliente.Direccion_cliente = txtDireccion.Text;
            viewModelCliente.Telefono_cliente = int.Parse(txtTelefono.Text);
            viewModelCliente.Email_cliente = txtEmail.Text;
            //viewModelCliente.Estado_cliente = int.Parse(txtEstado.Text);
            viewModelCliente.Estado_cliente = chkEstado.Checked ? 1 : 0;

            //if para cualquier cosa que necesite controlar
            if (txtID.Text != "")
            {
                viewModelCliente.Id_cliente = int.Parse(txtID.Text);
                Actualizar();
                ListarClientes();
            }
            else
            {
                Insertar();
                Limpiar();
                ListarClientes();
            }

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }
    }
}
