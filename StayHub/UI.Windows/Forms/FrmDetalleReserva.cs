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
        //
        private DetalleReservaController controllerDetalle;
        private DetalleReservaViewModel viewModelDetalle;

        public FrmDetalleReserva()
        {
            InitializeComponent();
            controllerDetalle = new DetalleReservaController();
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
            txtReserva.Text = "";
            txtHabitacion.Text = "";
            txtPersonas.Text = "";
            txtDias.Text = "";
            txtObservacion.Text = "";
            txtEstado.Text = "";
        }



        private void btnInsertar_Click(object sender, EventArgs e)
        {

            viewModelDetalle = new DetalleReservaViewModel();
            viewModelDetalle.Id_reserva = int.Parse(txtReserva.Text);
            viewModelDetalle.Id_habitacion  = int.Parse(txtReserva.Text);
            viewModelDetalle.Cantidad_personas = int.Parse(txtPersonas.Text);
            viewModelDetalle.Cantidad_dias = int.Parse(txtDias.Text);
            viewModelDetalle.Observaciones = txtObservacion.Text;
            viewModelDetalle.Estado = int.Parse(txtEstado.Text);

            //if para cualquier cosa que necesite controlar
            if (txtID.Text != "")
            {
                viewModelDetalle.Id_detalle = int.Parse(txtID.Text);
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
