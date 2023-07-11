using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class CabeceraReservaViewModel
    {
        public int Id_reserva { get; set; }
        public Nullable<int> Id_cliente { get; set; }
        public Nullable<int> Id_usuario { get; set; }
        public Nullable<System.DateTime> Fecha_reserva { get; set; }
        public Nullable<System.DateTime> Fecha_entrada { get; set; }
        public Nullable<System.DateTime> Fecha_salida { get; set; }
        public Nullable<int> Estado_reserva { get; set; }
        public string Observaciones { get; set; }
    }
}
