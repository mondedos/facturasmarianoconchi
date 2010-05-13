using System;
using System.Collections.Generic;

using System.Windows.Forms;
using iTextSharpSign;

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
#if !DEBUG
            string miFichCert = @"c:\CertificadoRicardo.p12";

            Cert myCert = null;
            try
            {
                myCert = new Cert(miFichCert, "hola");
#endif
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

#if !DEBUG
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                return;
            }
#endif

        }
    }
}
