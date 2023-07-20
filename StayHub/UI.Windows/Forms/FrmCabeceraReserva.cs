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
    public partial class FrmCabeceraReserva : Form
    {
        //Instanciar Controlador
        private EmpleadoController controllerEmpleado;
        private ClienteController controllerCliente;

        //
        private CabeceraReservaController controllerReserva;
        private CabeceraReservaViewModel viewModelReserva;

        public FrmCabeceraReserva()
        {
            InitializeComponent();
            controllerReserva = new CabeceraReservaController();

            controllerEmpleado = new EmpleadoController();
            controllerCliente = new ClienteController();

        }

        //Recuperamos lista de empleados Activos
        private void listarEmpleados()
        {
            cmbEmpleado.DataSource = controllerEmpleado.ListarEmpleadosActivos();
            cmbEmpleado.DisplayMember = "Nombre_Completo"; //El valor que quiero que muestre a seleccionar
            cmbEmpleado.ValueMember = "id_empleado"; //El valor que quiero que tome
        }

        private void listarClientes()
        {
            cmbCliente.DataSource = controllerCliente.ListarClientes();
            cmbCliente.DisplayMember = "nombre_cliente"; //El valor que quiero que muestre a seleccionar
            cmbCliente.ValueMember = "id_cliente"; //El valor que quiero que tome
        }

        //Insertar Empleado
        public void Insertar()
        {
            if (controllerReserva.InsertarCabeceraReserva(viewModelReserva))
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
            if (controllerReserva.ActualizarCabeceraReserva(viewModelReserva))
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
            //txtCliente.Text = "";
            //txtUsuario.Text = "";
            //txtFechaReserva.Text = "";
            dateReserva.Text = "";
            dateEntrada.Text = "";
            dateSalida.Text = "";
            chkEstado.Checked = false;
            txtObservacion.Text = "";
        }

        private void ListarReservas()
        {
            dgvAlquileres.DataSource = controllerReserva.ListarReservas();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            viewModelReserva = new CabeceraReservaViewModel();

            viewModelReserva.Id_cliente = (int?)cmbCliente.SelectedValue;
            viewModelReserva.Id_usuario = (int?)cmbEmpleado.SelectedValue;
            viewModelReserva.Fecha_reserva = DateTime.Parse(dateReserva.Text); 
            viewModelReserva.Fecha_entrada = DateTime.Parse(dateEntrada.Text);
            viewModelReserva.Fecha_salida = DateTime.Parse(dateSalida.Text);
            viewModelReserva.Estado_reserva = chkEstado.Checked ? 1 : 0;
            viewModelReserva.Observaciones = txtObservacion.Text;
           


            //if para cualquier cosa que necesite controlar
            if (txtID.Text != "")
            {
                viewModelReserva.Id_reserva = int.Parse(txtID.Text);
                Actualizar();
                Limpiar();
            }
            else
            {
                Insertar();
                Limpiar();
            }



        }

        private void FrmCabeceraReserva_Load(object sender, EventArgs e)
        {
            listarEmpleados();
            listarClientes();
            ListarReservas();
        }
    }
}
