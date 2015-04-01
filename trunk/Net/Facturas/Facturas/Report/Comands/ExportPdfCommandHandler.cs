using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;
using Facturas.BizzRules;
using Facturas.Properties;

namespace Facturas.Report.Comands
{
    public class ExportPdfCommandHandler : ICommandHandler
    {
        #region Implementation of ICommandHandler

        /// <summary>
        /// <para>
        /// If implemented by a class, allows you to handle Printing System commands (listed in the <see cref="T:DevExpress.XtraPrinting.PrintingSystemCommand"/> enumeration).
        /// </para>
        /// </summary>
        /// <param name="command">A <see cref="T:DevExpress.XtraPrinting.PrintingSystemCommand"/> enumeration value.
        ///             </param><param name="args">An array of <see cref="T:System.Object"/> values, specifying the command arguments.
        ///             </param><param name="printControl">An object implementing the <see cref="T:DevExpress.XtraPrinting.IPrintControl"/> interface (typically, this is a <see cref="T:DevExpress.XtraPrinting.Control.PrintControl"/> instance).
        ///             </param><param name="handled"><b>true</b> if the command has been handled; otherwise <b>false</b>.
        ///             </param>
        public void HandleCommand(PrintingSystemCommand command, object[] args, IPrintControl printControl, ref bool handled)
        {
            if (!CanHandleCommand(command, printControl)) return;

            DocumentViewer documentViewer = printControl as DocumentViewer;

            if (documentViewer != null)
            {
                // Set handled to 'true' to prevent the standard exporting procedure from being called.
                handled = true;

                XtraReportFactura xtraReportFactura = documentViewer.DocumentSource as XtraReportFactura;

                if (xtraReportFactura != null)
                {
                    Factura factura = xtraReportFactura.Factura;

                    string escritorio = Settings.Default.carpetaSalidaPDF;

                    string nombreFichero = Path.Combine(escritorio, string.Format("Factura-{0}.pdf", factura.Numero));

                    if (File.Exists(nombreFichero)
                        && XtraMessageBox.Show(string.Format(@"¿Desea sobreescribir el fichero '{0}'?", nombreFichero),
                        string.Format("Exportar a PDF la factura {0}", factura.Numero),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }

                    xtraReportFactura.ExportToPdf(nombreFichero);
                }
            }
           
        }

        /// <summary>
        /// <para>
        /// Indicates whether or not the specified Printing System command can be handled. 
        /// </para>
        /// </summary>
        /// <param name="command">A <see cref="T:DevExpress.XtraPrinting.PrintingSystemCommand"/> enumeration value.
        ///             </param><param name="printControl">An object implementing the <see cref="T:DevExpress.XtraPrinting.IPrintControl"/> interface (typically, this is a <see cref="T:DevExpress.XtraPrinting.Control.PrintControl"/> instance).
        ///             </param>
        /// <returns>
        /// <b>true</b> if the command can be handled; otherwise <b>false</b>.
        /// </returns>
        public bool CanHandleCommand(PrintingSystemCommand command, IPrintControl printControl)
        {
            return PrintingSystemCommand.ExportPdf == command;
        }

        #endregion
    }
}