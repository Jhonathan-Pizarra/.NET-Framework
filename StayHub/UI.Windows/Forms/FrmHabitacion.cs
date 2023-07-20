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
    public partial class FrmHabitacion : Form
    {
        //
        private HabitacionController controllerHabitacion;
        private HabitacionViewModel viewModelHabitacion;

        public FrmHabitacion()
        {
            InitializeComponent();
            controllerHabitacion = new HabitacionController();
        }

        //Metodo Insertar
        public void Insertar()
        {
            if (controllerHabitacion.InsertarHabitacion(viewModelHabitacion))
            {
                MessageBox.Show("Registro creado exitosamente!");
            }
            else
            {
                MessageBox.Show("Registro no se ha creado.");
            }
        }

        //Limpiar inputs
        public void Limpiar()
        {
            txtID.Text = "";
            txtCaracteristica.Text = "";
            //txtEstado.Text = "";
            chkEstado.Checked = false;
            txtNumero.Text = "";
            txtPiso.Text = "";
            txtPrecio.Text = "";
            txtTipo.Text = "";
        }


        //Actualizar 
        public void Actualizar()
        {
            if (controllerHabitacion.ModificarHabitacion(viewModelHabitacion))
            {
                MessageBox.Show("Registro modificado exitosamente!");
            }
            else
            {
                MessageBox.Show("Registro no se ha modificado.");
            }
        }


        private void ListarHabitaciones()
        {
            dgvHabitacion.DataSource = controllerHabitacion.ListarHabitaciones();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            viewModelHabitacion = new HabitacionViewModel();
            viewModelHabitacion.Numero_habitacion = int.Parse(txtNumero.Text);
            viewModelHabitacion.Piso_habitacion = int.Parse(txtPiso.Text);
            viewModelHabitacion.Preciodiario_habitacion = double.Parse(txtPrecio.Text);
            viewModelHabitacion.Tipo_habitacion = txtTipo.Text;
            viewModelHabitacion.Caracteristicas_habitacion = txtCaracteristica.Text;
            //viewModelHabitacion.Estado_habitacion = int.Parse(txtEstado.Text);
            viewModelHabitacion.Estado_habitacion = chkEstado.Checked ? 1 : 0;


            //if para cualquier cosa que necesite controlar
            if (txtID.Text != "")
            {
                viewModelHabitacion.Id_habitacion = int.Parse(txtID.Text);
                Actualizar();
                ListarHabitaciones();

            }
            else
            {
                Insertar();
                Limpiar();
                ListarHabitaciones();

            }

        }

        private void FrmHabitacion_Load(object sender, EventArgs e)
        {
            ListarHabitaciones();
        }
    }
}
