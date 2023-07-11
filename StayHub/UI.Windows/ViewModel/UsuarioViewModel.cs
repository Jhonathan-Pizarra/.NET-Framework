using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class UsuarioViewModel
    {
        public int Id_usuario { get; set; }
        public Nullable<int> Id_empleado { get; set; }
        public string Usuario1 { get; set; }
        public string Contraseña { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
