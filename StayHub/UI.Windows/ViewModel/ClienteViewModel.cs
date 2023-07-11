using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class ClienteViewModel
    {
        public int Id_cliente { get; set; }
        public string Identificacion_cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Apellido_cliente { get; set; }
        public string Direccion_cliente { get; set; }
        public Nullable<int> Telefono_cliente { get; set; }
        public string Email_cliente { get; set; }
        public Nullable<int> Estado_cliente { get; set; }
    }
}
