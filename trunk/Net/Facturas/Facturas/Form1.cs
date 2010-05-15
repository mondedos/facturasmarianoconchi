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
using System.Xml.Serialization;
using System.IO;

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


            bsLineas.AddingNew += new AddingNewEventHandler(bsLineas_AddingNew);
            bsFactura.AddingNew += new AddingNewEventHandler(bsFactura_AddingNew);

            //nuevoFacturaToolStripMenuItem_Click(this, EventArgs.Empty);
            HabilitarGenerar(false);
        }

        void bsFactura_AddingNew(object sender, AddingNewEventArgs e)
        {
            Factura f = new Factura();

            e.NewObject = f;

            f.Fecha = DateTime.Now;
            f.Numero = 0;


        }

        void bsLineas_AddingNew(object sender, AddingNewEventArgs e)
        {

            e.NewObject = new LineaFactura();

            LineaFactura linea = e.NewObject as LineaFactura;

            linea.HorasEuros = Settings.Default.eurosXHora;
            linea.KilometrosEuros = Settings.Default.eurosXKilometros;

        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HabilitarGenerar(bool value)
        {
            generarFicheroFacturaPDFToolStripMenuItem.Enabled = value;
            toolStripButtonGenerar.Enabled = value;
            guardarFacturaToolStripMenuItem.Enabled = value;
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
            //bsLineas.AddNew();

            bindingNavigatorAddNewItem_Click(sender, e);
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

        private void txtKilomestrosEuros_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            float euros;

            if (float.TryParse(tb.Text, out euros))
            {
                tb.Text = String.Format("{0:C}", euros);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nuevoFacturaToolStripMenuItem_Click(sender, e);

            bsFactura.AddNew();

            numeroTextBox.Focus();
            //bsLineas.EndEdit();
            //bsLineas.List.Clear();
            //bsLineas.AddNew();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bool activar = Convert.ToBoolean(bsLineas.List.Count);
            gbLineas.Enabled = activar;
            HabilitarGenerar(activar);

        }

        private void cargarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sabeD = new SaveFileDialog();

            sabeD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            sabeD.Title = "Guardar Factura como...";
            sabeD.Filter = "Factura (*.taxi)|*.taxi";

            if (sabeD.ShowDialog(this) == DialogResult.OK)
            {
                Factura fact = bsFactura.Current as Factura;



            }
        }

        private void cargarDatosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Title = "Seleccione los datos del cliente";
            openFileDialog.Filter = "Factura (*.upo)|*.upo";


            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Cliente myObject;
                // Construct an instance of the XmlSerializer with the type
                // of object that is being deserialized.
                XmlSerializer mySerializer =
                new XmlSerializer(typeof(Cliente));
                // To read the file, create a FileStream.
                FileStream myFileStream =
                new FileStream(openFileDialog.FileName, FileMode.Open);
                // Call the Deserialize method and cast to the object type.
                myObject = (Cliente)mySerializer.Deserialize(myFileStream);

                Factura fact = bsFactura.Current as Factura;


                Util.CopiarPropiedadesTipo(myObject, fact);

                bsFactura.ResetCurrentItem();

            }
        }

        private void guardarDatosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sabeD = new SaveFileDialog();

            sabeD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            sabeD.Title = "Guardar Datos Cliente como...";
            sabeD.Filter = "Factura (*.upo)|*.upo";

            if (sabeD.ShowDialog(this) == DialogResult.OK)
            {
                Factura fact = bsFactura.Current as Factura;

                Cliente myObject = new Cliente();

                Util.CopiarPropiedadesTipo(fact, myObject);

                // Insert code to set properties and fields of the object.
                XmlSerializer mySerializer = new
                XmlSerializer(typeof(Cliente));
                // To write to a file, create a StreamWriter object.
                StreamWriter myWriter = new StreamWriter(sabeD.FileName);
                mySerializer.Serialize(myWriter, myObject);
                myWriter.Close();


            }
        }
    }
}
