using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Facturas.BizzRules;
using iTextSharpSign;
using System.Diagnostics;
using Facturas.Properties;

namespace Facturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripButtonGenerar.Text = generarFicheroFacturaPDFToolStripMenuItem.Text;
            toolStripButtonNuevo.Text = nuevoFacturaToolStripMenuItem.Text;
            //pictureBox1.Image = Base64ToImage.ConvertThis("Hola mundo");
            bsFactura.AddNew();
            bsLineas.AddNew();

        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generarFicheroFacturaPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bsFactura.EndEdit();
            Factura factura = bsFactura.Current as Factura;

            bsLineas.EndEdit();



            factura.Lineas.Clear();
            foreach (LineaFactura item in bsLineas.List)
            {
                factura.Lineas.Add(item);
            }

            (new PDFGenerador(factura)).Run();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion conf = new Configuracion();


            conf.ShowDialog();
        }

        private void nuevoFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bsFactura.EndEdit();
            bsFactura.List.Clear();
            bsFactura.AddNew();


            bsLineas.EndEdit();
            bsLineas.List.Clear();
            bsLineas.AddNew();
        }

        private void toolStripButtonGenerar_Click(object sender, EventArgs e)
        {
            generarFicheroFacturaPDFToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            nuevoFacturaToolStripMenuItem_Click(sender, e);
        }

        private void firmarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openCertificadoFileDialog = new OpenFileDialog();
            openCertificadoFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openCertificadoFileDialog.Title = "Seleccione su certificado de usuario";
            openCertificadoFileDialog.Filter = "Certificado Digital (*.p12)|*.p12";


            if (openCertificadoFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openCertificadoFileDialog.FileName))
                {
                    Passs pass = new Passs();

                    if (pass.ShowDialog() == DialogResult.OK)
                    {

                        Cert myCert = null;
                        try
                        {
                            myCert = new Cert(openCertificadoFileDialog.FileName, pass.Password);



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Application.ProductName);
                            return;
                        }

                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                        openFileDialog.Title = "Seleccione una factura sin firmar";
                        openFileDialog.Filter = "Factura (*.pdf)|*.pdf";


                        if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                        {

                            if (!string.IsNullOrEmpty(openFileDialog.FileName))
                            {
                                MetaData MyMD = new MetaData();
                                MyMD.Author = Settings.Default.nombre;
                                MyMD.Title = string.Format("Factura emitida por {0}", Settings.Default.nombre);
                                MyMD.Subject = "Factura por translado en taxi";
                                MyMD.Keywords = "factura, taxi, mariano";
                                MyMD.Creator = "Riccardo Prieto Mendoza";
                                MyMD.Producer = "Riccardo Prieto Mendoza";

                                SaveFileDialog sabeD = new SaveFileDialog();

                                sabeD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                                sabeD.Title = "Guardar Factura Firmada como...";
                                sabeD.Filter = "Factura (*.pdf)|*.pdf";


                                if (sabeD.ShowDialog(this) == DialogResult.OK)
                                {
                                    PDFSigner pdfs = new PDFSigner(openFileDialog.FileName, sabeD.FileName, myCert, MyMD);
                                    pdfs.Sign("Factura por translado en taxi", Settings.Default.email, Settings.Default.direccion + " " + Settings.Default.poblacionCP, false);


                                    Process.Start(sabeD.FileName);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
