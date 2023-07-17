using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.Forms;

namespace UI.Windows
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmEmpleado());
            //Application.Run(new FrmCliente());
            //Application.Run(new FrmHabitacion());
            //Application.Run(new FrmUsuario());
            //Application.Run(new FrmCabeceraReserva());
            //Application.Run(new FrmDetalleReserva());

        }
    }
}
