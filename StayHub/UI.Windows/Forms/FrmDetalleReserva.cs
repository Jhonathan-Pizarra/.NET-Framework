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
    public partial class FrmDetalleReserva : Form
    {
        private CabeceraReservaController controllerReserva;
        private HabitacionController controllerHabitacion;
        //
        private DetalleReservaController controllerDetalle;
        private DetalleReservaViewModel viewModelDetalle;

        public FrmDetalleReserva()
        {
            InitializeComponent();
            controllerDetalle = new DetalleReservaController();
            controllerReserva = new CabeceraReservaController();
            controllerHabitacion = new HabitacionController();
        }

        //Insertar Empleado
        public void Insertar()
        {
            if (controllerDetalle.InsertarDetalleReserva(viewModelDetalle))
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
            if (controllerDetalle.ActualizarDetalleReserva(viewModelDetalle))
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
            txtPersonas.Text = "";
            txtDias.Text = "";
            txtObservacion.Text = "";
            chkEstado.Checked = false;
        }

      

        private void ListarDetalles()
        {
            dgvDetalle.DataSource = controllerDetalle.ListarReservas();
        }

        private void ListarHabitaciones()
        {
            cmbHabitacion.DataSource = controllerHabitacion.ListarHabitaciones();
            cmbHabitacion.DisplayMember = "tipo_habitacion"; //El valor que quiero que muestre a seleccionar
            cmbHabitacion.ValueMember = "id_habitacion"; //El valor que quiero que tome
        }

        private void ListarReservas()
        {
            cmbReserva.DataSource = controllerReserva.ListarReservas();
            cmbReserva.DisplayMember = "fecha_reserva"; //El valor que quiero que muestre a seleccionar
            cmbReserva.ValueMember = "id_reserva"; //El valor que quiero que tome
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {

            viewModelDetalle = new DetalleReservaViewModel();
            viewModelDetalle.Id_reserva = (int?)cmbReserva.SelectedValue;
            viewModelDetalle.Id_habitacion  = (int?)cmbHabitacion.SelectedValue;
            viewModelDetalle.Cantidad_personas = int.Parse(txtPersonas.Text);
            viewModelDetalle.Cantidad_dias = int.Parse(txtDias.Text);
            viewModelDetalle.Observaciones = txtObservacion.Text;
            viewModelDetalle.Estado = chkEstado.Checked ? 1 : 0;

            //if para cualquier cosa que necesite controlar
            if (txtID.Text != "")
            {
                viewModelDetalle.Id_detalle = int.Parse(txtID.Text);
                Actualizar();
                ListarDetalles();
            }
            else
            {
                Insertar();
                Limpiar();
                ListarDetalles();
            }


        }

        private void FrmDetalleReserva_Load(object sender, EventArgs e)
        {
            ListarDetalles();
            ListarHabitaciones();
            ListarReservas();
        }
    }
}
