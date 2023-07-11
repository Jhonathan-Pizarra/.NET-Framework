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
        //
        private CabeceraReservaController controllerReserva;
        private CabeceraReservaViewModel viewModelReserva;

        public FrmCabeceraReserva()
        {
            InitializeComponent();
            controllerReserva = new CabeceraReservaController();
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
            txtCliente.Text = "";
            txtUsuario.Text = "";
            txtFechaReserva.Text = "";
            txtFechaEntrada.Text = "";
            txtFechaSalida.Text = "";
            txtEstado.Text = "";
            txtObservacion.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            viewModelReserva = new CabeceraReservaViewModel();

            viewModelReserva.Id_cliente = int.Parse(txtCliente.Text);
            viewModelReserva.Id_usuario = int.Parse(txtUsuario.Text);
            viewModelReserva.Fecha_reserva = DateTime.Parse(txtFechaReserva.Text);
            viewModelReserva.Fecha_entrada = DateTime.Parse(txtFechaEntrada.Text);
            viewModelReserva.Fecha_salida = DateTime.Parse(txtFechaSalida.Text);
            viewModelReserva.Estado_reserva = int.Parse(txtEstado.Text);
            viewModelReserva.Observaciones = txtEstado.Text;


            //if para cualquier cosa que necesite controlar
            if (txtID.Text != "")
            {
                viewModelReserva.Id_reserva = int.Parse(txtID.Text);
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
