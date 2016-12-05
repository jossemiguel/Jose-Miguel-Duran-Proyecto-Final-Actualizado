using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginUsuario.Login());
            Application.Run(new MenuPrincipal.Menu());
          //  //Application.Run(new MenuPrincipal.Ventas.RegistroUsuarios.RegistroEmpleados());
            // Application.Run(new MenuPrincipal.Compras.RegistroCompras());
            //Application.Run(new Ventas.RegistroUsuarios.RegistroVentas());

        }
    }
}
