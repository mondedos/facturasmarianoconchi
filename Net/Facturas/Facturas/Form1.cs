﻿using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using Facturas.BizzRules;
using System.Diagnostics;
using Facturas.Properties;
using System.Xml.Serialization;
using System.IO;

namespace Facturas
{
    public partial class Form1 : Form, ILineaFactura
    {
        private int _current = -1;
        private string _elPrecioDeLasHorasDeEsperaNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO = "El precio de las horas de espera no es correcto, por favor introduce una canidad en euros o 0€.";
        private string _losCkilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO = "Los ckilometros no es correcto, por favor introduce una canidad en euros o 0€.";
        private string _lasHorasDeEsperaNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO = "Las horas de espera no es correcta, por favor introduce una canidad en euros o 0€.";
        private string _laCantidadNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO = "La cantidad no es correcta, por favor introduce una canidad en euros o 0€.";
        private string _elPrecioDeLosKilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO = "El precio de los kilometros no es correcto, por favor introduce una canidad en euros o 0€.";

        public Form1()
        {
            InitializeComponent();
            toolStripButtonGenerar.Text = generarFicheroFacturaPDFToolStripMenuItem.Text;
            toolStripButtonNuevo.Text = nuevoFacturaToolStripMenuItem.Text;
            //pictureBox1.Image = Base64ToImage.ConvertThis("Hola mundo");


            bsFactura.AddingNew += new AddingNewEventHandler(bsFactura_AddingNew);

            //nuevoFacturaToolStripMenuItem_Click(this, EventArgs.Empty);
            HabilitarGenerar(false);

        }

        void bsFactura_AddingNew(object sender, AddingNewEventArgs e)
        {
            Factura f = new Factura();

            e.NewObject = f;

            f.Fecha = DateTime.Now;
            f.Numero = Settings.Default.ultimaFactura + 1;


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
            if (!DatosLineaValido()) return;
            bsFactura.EndEdit();
            Factura factura = bsFactura.Current as Factura;

            ActualizarContadoresLineas();

            (new PdfGenerador(factura)).Run();

            if (factura != null) Settings.Default.ultimaFactura = factura.Numero;
            Settings.Default.Save();
        }

        private bool DatosLineaValido()
        {
            Factura c = bsFactura.Current as Factura;

            StringBuilder sb = new StringBuilder();

            errorProvider1.Clear();

            if (c != null)
                if (Convert.ToBoolean(c.Lineas.Count))
                {
                    float cantidad = 0;

                    if (!float.TryParse(cantidadTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
                    {
                        errorProvider1.SetError(cantidadTextBox, _laCantidadNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO);
                        sb.AppendLine(_laCantidadNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO);
                    }
                    if (!float.TryParse(horasEsperaTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
                    {
                        errorProvider1.SetError(horasEsperaTextBox, _lasHorasDeEsperaNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO);
                        sb.AppendLine(_lasHorasDeEsperaNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO);
                    }
                    if (!float.TryParse(kilometrosTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
                    {
                        errorProvider1.SetError(kilometrosTextBox, _losCkilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
                        sb.AppendLine(_losCkilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
                    }
                    if (!float.TryParse(txtHorasEuros.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
                    {
                        errorProvider1.SetError(txtHorasEuros, _elPrecioDeLasHorasDeEsperaNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
                        sb.AppendLine(_elPrecioDeLasHorasDeEsperaNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
                    }
                    if (!float.TryParse(txtKilomestrosEuros.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
                    {
                        errorProvider1.SetError(txtKilomestrosEuros, _elPrecioDeLosKilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
                        sb.AppendLine(_elPrecioDeLosKilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
                    }

                }
            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return sb.Length == 0;
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


            bindingNavigatorAddNewItem_Click(sender, e);

            _current = -1;

            gbLineas.Enabled = false;
            HabilitarGenerar(false);

            ActualizarContradoresLineasForm();
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
            openCertificadoFileDialog.Title = Facturas.Form1_firmarFacturaToolStripMenuItem_Click_Seleccione_su_certificado_de_usuario;
            openCertificadoFileDialog.Filter = Facturas.Form1_firmarFacturaToolStripMenuItem_Click_Certificado_Digital____p12____p12;


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
                        openFileDialog.Title = Facturas.Form1_firmarFacturaToolStripMenuItem_Click_Seleccione_una_factura_sin_firmar;
                        openFileDialog.Filter = Facturas.Form1_firmarFacturaToolStripMenuItem_Click_Factura____pdf____pdf;


                        if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                        {

                            if (!string.IsNullOrEmpty(openFileDialog.FileName))
                            {
                                MetaData myMd = new MetaData();
                                myMd.Author = Settings.Default.nombre;
                                myMd.Title = string.Format("Factura emitida por {0}", Settings.Default.nombre);
                                myMd.Subject = "Factura por translado en taxi";
                                myMd.Keywords = "factura, taxi, mariano";
                                myMd.Creator = "Riccardo Prieto Mendoza";
                                myMd.Producer = "Riccardo Prieto Mendoza";

                                SaveFileDialog sabeD = new SaveFileDialog();

                                sabeD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                                sabeD.Title = Facturas.Form1_firmarFacturaToolStripMenuItem_Click_Guardar_Factura_Firmada_como___;
                                sabeD.Filter = Facturas.Form1_firmarFacturaToolStripMenuItem_Click_Factura____pdf____pdf;


                                if (sabeD.ShowDialog(this) == DialogResult.OK)
                                {
                                    PdfSigner pdfs = new PdfSigner(openFileDialog.FileName, sabeD.FileName, myCert, myMd);
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

            ActualizarContradoresLineasForm();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //bool activar = Convert.ToBoolean(bsLineas.List.Count);
            //gbLineas.Enabled = activar;
            //HabilitarGenerar(activar);

        }

        private void cargarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sabeD = new SaveFileDialog();

            sabeD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            sabeD.Title = Facturas.Form1_guardarFacturaToolStripMenuItem_Click_Guardar_Factura_como___;
            sabeD.Filter = Facturas.Form1_guardarFacturaToolStripMenuItem_Click_Factura____taxi____taxi;

            if (sabeD.ShowDialog(this) == DialogResult.OK)
            {
                Factura fact = bsFactura.Current as Factura;



            }
        }

        private void cargarDatosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Title = Facturas.Form1_cargarDatosClienteToolStripMenuItem_Click_Seleccione_los_datos_del_cliente;
            openFileDialog.Filter = Facturas.Form1_guardarDatosClienteToolStripMenuItem_Click_Factura____upo____upo;


            if (openFileDialog.ShowDialog(this) != DialogResult.OK) return;
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

        private void guardarDatosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sabeD = new SaveFileDialog();

            sabeD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            sabeD.Title = Facturas.Form1_guardarDatosClienteToolStripMenuItem_Click_Guardar_Datos_Cliente_como___;
            sabeD.Filter = Facturas.Form1_guardarDatosClienteToolStripMenuItem_Click_Factura____upo____upo;

            if (sabeD.ShowDialog(this) != DialogResult.OK) return;
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
     
        private void toolStripButtonInsertar_Click(object sender, EventArgs e)
        {
            if (!DatosLineaValido()) return;
            ActualizarContadoresLineas();

            Factura c = bsFactura.Current as Factura;

            LineaFactura nl = new LineaFactura();

            nl.HorasEuros = Settings.Default.eurosXHora;
            nl.KilometrosEuros = Settings.Default.eurosXKilometros;
            nl.Concepto = string.Empty;

            _current++;
            c.Lineas.Add(nl);

            bool activar = Convert.ToBoolean(c.Lineas.Count);
            gbLineas.Enabled = activar;
            HabilitarGenerar(activar);



            ActualizarContradoresLineasForm();
        }
        public void ActualizarContadoresLineas()
        {
            if (_current < 0) return;
            Factura c = bsFactura.Current as Factura;


            if (c == null) return;
            LineaFactura nl = c.Lineas[_current] as LineaFactura;

            Util.CopiarPropiedadesTipo(this, nl);
        }
        public void ActualizarContradoresLineasForm()
        {
            Factura c = bsFactura.Current as Factura;
            if (c == null) return;
            toolStripTextBoxActual.Text = Convert.ToString(_current + 1);
            toolStripLabelTotal.Text = string.Format("de {0} líneas de factura", c.Lineas.Count);

            if (_current < 0) return;
            
            LineaFactura nl = c.Lineas[_current] as LineaFactura;

            Util.CopiarPropiedadesTipo(nl, this);
        }
        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            Factura c = bsFactura.Current as Factura;

            if (_current > -1)
            {
                LineaFactura act = c.Lineas[_current] as LineaFactura;

                c.Lineas.Remove(act);

                if (_current >= c.Lineas.Count)
                {
                    _current = c.Lineas.Count - 1;
                }
            }

            ActualizarContradoresLineasForm();
        }

        private void toolStripButtonSiguiente_Click(object sender, EventArgs e)
        {
            if (!DatosLineaValido()) return;
            ActualizarContadoresLineas();


            Factura c = bsFactura.Current as Factura;

            if (c != null)
                if (Convert.ToBoolean(c.Lineas.Count) && _current < (c.Lineas.Count - 1))
                {
                    _current++;
                    ActualizarContradoresLineasForm();
                }
        }

        private void toolStripButtonAnterior_Click(object sender, EventArgs e)
        {
            if (!DatosLineaValido()) return;
            ActualizarContadoresLineas();

            Factura c = bsFactura.Current as Factura;

            if (c != null)
                if (Convert.ToBoolean(c.Lineas.Count) && Convert.ToBoolean(_current))
                {
                    _current--;
                    ActualizarContradoresLineasForm();
                }
        }

        private void toolStripButtonUltimo_Click(object sender, EventArgs e)
        {
            if (!DatosLineaValido()) return;
            ActualizarContadoresLineas();

            Factura c = bsFactura.Current as Factura;

            if (c != null)
                if (Convert.ToBoolean(c.Lineas.Count))
                {
                    _current = c.Lineas.Count - 1;
                    ActualizarContradoresLineasForm();
                }
        }

        private void toolStripButtonPrimero_Click(object sender, EventArgs e)
        {
            if (!DatosLineaValido()) return;
            ActualizarContadoresLineas();

            Factura c = bsFactura.Current as Factura;

            if (c != null)
                if (Convert.ToBoolean(c.Lineas.Count))
                {
                    _current = 0;

                    ActualizarContradoresLineasForm();
                }
        }
        #region ILineaFactura Members

        public decimal Cantidad
        {
            get
            {
                return decimal.Parse(cantidadTextBox.Text, System.Globalization.NumberStyles.Any);
            }
            set
            {
                cantidadTextBox.Text = String.Format("{0:C}", value);
            }
        }

        public string Concepto
        {
            get
            {
                return conceptoTextBox.Text;
            }
            set
            {
                conceptoTextBox.Text = value;
            }
        }

        public decimal HorasEspera
        {
            get
            {
                return Convert.ToDecimal(horasEsperaTextBox.Text);
            }
            set
            {
                horasEsperaTextBox.Text = Convert.ToString(value);
            }
        }

        public decimal Kilometros
        {
            get
            {
                return Convert.ToDecimal(kilometrosTextBox.Text);
            }
            set
            {
                kilometrosTextBox.Text = Convert.ToString(value);
            }
        }

        public decimal KilometrosEuros
        {
            get
            {
                return decimal.Parse(txtKilomestrosEuros.Text, System.Globalization.NumberStyles.Any);
            }
            set
            {
                txtKilomestrosEuros.Text = String.Format("{0:C}", value);
            }
        }

        public decimal HorasEuros
        {
            get
            {
                return decimal.Parse(txtHorasEuros.Text, System.Globalization.NumberStyles.Any);
            }
            set
            {
                txtHorasEuros.Text = String.Format("{0:C}", value);
            }
        }

        #endregion

        private void codigoPostalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void cantidadTextBox_Enter(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            if (t != null) t.SelectAll();
        }

        private void codigoPostalTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            int valor;


            if (tb != null && !string.IsNullOrEmpty(tb.Text))
            {
                errorProvider1.SetError(tb,string.Empty);
                if (!int.TryParse(tb.Text, out valor))
                {
                    errorProvider1.SetError(tb, "El código postal debe ser un número entero de 5 cifras.");
                }
            }
        }

        private void cantidadTextBox_Validating(object sender, CancelEventArgs e)
        {
            float cantidad;
            errorProvider1.SetError(cantidadTextBox,string.Empty);
            if(!float.TryParse(cantidadTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(cantidadTextBox, _laCantidadNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO);
            }
        }

        private void horasEsperaTextBox_Validating(object sender, CancelEventArgs e)
        {
            float cantidad;

            
            if (!float.TryParse(horasEsperaTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(horasEsperaTextBox, _lasHorasDeEsperaNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO);
            }
        }

        private void kilometrosTextBox_Validating(object sender, CancelEventArgs e)
        {
            float cantidad;
                 
            if (!float.TryParse(kilometrosTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(kilometrosTextBox, _losCkilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
            }
        }

        private void txtHorasEuros_Validating(object sender, CancelEventArgs e)
        {
            float cantidad;
            if (!float.TryParse(txtHorasEuros.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(txtHorasEuros, _elPrecioDeLasHorasDeEsperaNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
            }
            
        }

        private void txtKilomestrosEuros_Validating(object sender, CancelEventArgs e)
        {
            float cantidad;
            if (!float.TryParse(txtKilomestrosEuros.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(txtKilomestrosEuros, _elPrecioDeLosKilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
            }
        }


    }
}
