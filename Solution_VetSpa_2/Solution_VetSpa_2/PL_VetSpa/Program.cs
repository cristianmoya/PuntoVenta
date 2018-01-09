using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL_VetSpa.Generales;
using PL_VetSpa.Pantallas.Cat_Mant.Inventarios;
using PL_VetSpa.Inventarios;
using PL_VetSpa.Pantallas.Cat_Mant.Facturacion;

namespace PL_VetSpa
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
            Application.Run(new frm_Inicio());
        }
    }
}
