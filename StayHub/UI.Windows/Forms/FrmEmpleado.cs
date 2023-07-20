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

namespace UI.Windows
{
    public partial class FrmEmpleado : System.Windows.Forms.Form
    {
        //
        private EmpleadoController controllerEmpleado;
        private EmpleadoViewModel viewModelEmpleado;

        public FrmEmpleado()
        {
            InitializeComponent();
            controllerEmpleado = new EmpleadoController();
        }

        //Insertar Empleado
        public void Insertar()
        {
            if (controllerEmpleado.InsertarEmpleado(viewModelEmpleado))
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
            if (controllerEmpleado.ActualizarEmpleado(viewModelEmpleado))
            {
                MessageBox.Show("Registro modificado exitosamente!");
            }
            else
            {
                MessageBox.Show("Registro no se ha modificado.");
            }
        }

        //Limpiar
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
            txtObservaciones.Text = "";
        }

        private void ListarActivos()
        {
            //Listar Activos
            dgvListaEmpleados.DataSource = controllerEmpleado.ListarEmpleadosActivos();
            //Listar todos
            dgvListaEmpleados.DataSource = controllerEmpleado.ListarEmpleados();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            viewModelEmpleado = new EmpleadoViewModel();
            viewModelEmpleado.Nombre_empleado = txtNombre.Text;
            viewModelEmpleado.Apellido_empleado = txtApellido.Text;
            viewModelEmpleado.Direccion_empleado = txtDireccion.Text;   
            viewModelEmpleado.Telefono_empleado = int.Parse(txtTelefono.Text); 
            viewModelEmpleado.Email_empleado = txtEmail.Text;
            viewModelEmpleado.Observaciones_empleado = txtObservaciones.Text;   
            viewModelEmpleado.Estado_empleado = chkEstado.Checked ? 1 : 0;

            //if para cualquier cosa que necesite controlar
            if (txtID.Text != "")
            {
                viewModelEmpleado.Id_empleado = int.Parse(txtID.Text);
                Actualizar();
            }
            else
            {
                Insertar();
                Limpiar();
            }
            ListarActivos();


        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            ListarActivos();
        }

        private void dgvListaEmpleados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Si selecciona una celda y esta no está vacia
            if (dgvListaEmpleados.SelectedRows.Count > 0)
            {
                //Carga en el input la información del empleado seleccionado:
                txtID.Text = dgvListaEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvListaEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvListaEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = dgvListaEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgvListaEmpleados.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvListaEmpleados.CurrentRow.Cells[5].Value.ToString();
                txtObservaciones.Text = dgvListaEmpleados.CurrentRow.Cells[6].Value.ToString();

                if (dgvListaEmpleados.CurrentRow.Cells[7].Value.ToString() == "1")
                {
                    chkEstado.Checked = true;
                }


            }
        }
    }
}
