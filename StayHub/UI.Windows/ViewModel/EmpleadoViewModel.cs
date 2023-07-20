using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class EmpleadoViewModel
    {
        public int Id_empleado { get; set; }
        public string Nombre_empleado { get; set; }
        public string Apellido_empleado { get; set; }
        public string Direccion_empleado { get; set; }
        public Nullable<int> Telefono_empleado { get; set; }
        public string Email_empleado { get; set; }
        public string Observaciones_empleado { get; set; }
        public Nullable<int> Estado_empleado { get; set; }

        //Personalizacion ComboBox
        public string Nombre_Completo { get; set; }
    }
}
