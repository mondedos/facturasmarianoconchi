using System;
using System.Globalization;
using System.Windows.Forms;

namespace Facturas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());


        }
    }
}
