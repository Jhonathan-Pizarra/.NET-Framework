using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class HabitacionViewModel
    {
        public int Id_habitacion { get; set; }
        public Nullable<int> Numero_habitacion { get; set; }
        public Nullable<int> Piso_habitacion { get; set; }
        public Nullable<double> Preciodiario_habitacion { get; set; }
        public string Tipo_habitacion { get; set; }
        public string Caracteristicas_habitacion { get; set; }
        public Nullable<int> Estado_habitacion { get; set; }
    }
}
