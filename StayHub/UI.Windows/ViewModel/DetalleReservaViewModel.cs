using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class DetalleReservaViewModel
    {
        public int Id_detalle { get; set; }
        public Nullable<int> Id_reserva { get; set; }
        public Nullable<int> Id_habitacion { get; set; }
        public Nullable<int> Cantidad_personas { get; set; }
        public Nullable<int> Cantidad_dias { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
