using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Facturas.BizzRules;
using System.Diagnostics;
using Facturas.Properties;
using System.Xml.Serialization;
using System.IO;

namespace Facturas
{
    public partial class Form1 : XtraForm, ILineaFactura
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


            bsFactura.AddingNew += bsFactura_AddingNew;

            //nuevoFacturaToolStripMenuItem_Click(this, EventArgs.Empty);
            HabilitarGenerar(false);

        }

        void bsFactura_AddingNew(object sender, AddingNewEventArgs e)
        {
            Factura factura = new Factura();

            e.NewObject = factura;

            factura.Fecha = DateTime.Now;
            factura.Numero = Settings.Default.ultimaFactura + 1;


        }

        void bsLineas_AddingNew(object sender, AddingNewEventArgs e)
        {

            e.NewObject = new LineaFactura();

            LineaFactura linea = e.NewObject as LineaFactura;

            linea.HorasEuros = Settings.Default.eurosXHora;
            linea.KilometrosEuros = Settings.Default.eurosXKilometros;

        }


        private void SalirToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HabilitarGenerar(bool value)
        {
            generarFicheroFacturaPDFToolStripMenuItem.Enabled = value;
            toolStripButtonGenerar.Enabled = value;
            guardarFacturaToolStripMenuItem.Enabled = value;
        }
        private void GenerarFicheroFacturaPdfToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (!DatosLineaValido()) return;
            bsFactura.EndEdit();
            Factura factura = bsFactura.Current as Factura;

            ActualizarContadoresLineas();

            try
            {
                (new PdfGenerador(factura)).Run();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

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
                XtraMessageBox.Show(sb.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return sb.Length == 0;
        }

        private void ConfigurarToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (Configuracion conf = new Configuracion())
            {
                conf.ShowDialog();
            }
        }

        private void NuevoFacturaToolStripMenuItemClick(object sender, EventArgs e)
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

        private void ToolStripButtonGenerarClick(object sender, EventArgs e)
        {
            GenerarFicheroFacturaPdfToolStripMenuItemClick(sender, e);
        }

        private void ToolStripButtonNuevoClick(object sender, EventArgs e)
        {
            NuevoFacturaToolStripMenuItemClick(sender, e);
        }

        private void FirmarFacturaToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openCertificadoFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    Title = FacturasRecursos.Form1_firmarFacturaToolStripMenuItem_Click_Seleccione_su_certificado_de_usuario,
                    Filter = FacturasRecursos.Form1_firmarFacturaToolStripMenuItem_Click_Certificado_Digital____p12____p12
                })
            {
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
                                XtraMessageBox.Show(ex.Message, Application.ProductName);
                                return;
                            }

                            OpenFileDialog openFileDialog = new OpenFileDialog
                                {
                                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                                    Title =
                                        FacturasRecursos.
                                            Form1_firmarFacturaToolStripMenuItem_Click_Seleccione_una_factura_sin_firmar,
                                    Filter =
                                        FacturasRecursos.
                                            Form1_firmarFacturaToolStripMenuItem_Click_Factura____pdf____pdf
                                };


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

                                    using (SaveFileDialog sabeD = new SaveFileDialog
                                        {
                                            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                                            Title = FacturasRecursos.Form1_firmarFacturaToolStripMenuItem_Click_Guardar_Factura_Firmada_como___,
                                            Filter = FacturasRecursos.Form1_firmarFacturaToolStripMenuItem_Click_Factura____pdf____pdf
                                        })
                                    {
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
            }
        }

        private void TxtKilomestrosEurosTextChanged(object sender, EventArgs e)
        {

        }
        private void DecimalesCalculadoraOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {

                e.KeyChar =
                    Convert.ToChar(
                        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            }
        }
        private void Form1Load(object sender, EventArgs e)
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

        private void GuardarFacturaToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (SaveFileDialog sabeD = new SaveFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    Title = FacturasRecursos.Form1_guardarFacturaToolStripMenuItem_Click_Guardar_Factura_como___,
                    Filter = FacturasRecursos.Form1_guardarFacturaToolStripMenuItem_Click_Factura____taxi____taxi
                })
            {
                if (sabeD.ShowDialog(this) == DialogResult.OK)
                {
                    Factura fact = bsFactura.Current as Factura;



                }
            }
        }

        private void CargarDatosClienteToolStripMenuItemClick(object sender, EventArgs e)
        {
            Cliente myObject;
            XmlSerializer mySerializer;
            FileStream myFileStream;
            using (OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    Title = FacturasRecursos.Form1_cargarDatosClienteToolStripMenuItem_Click_Seleccione_los_datos_del_cliente,
                    Filter = FacturasRecursos.Form1_guardarDatosClienteToolStripMenuItem_Click_Factura____upo____upo
                })
            {
                if (openFileDialog.ShowDialog(this) != DialogResult.OK) return;
                // Construct an instance of the XmlSerializer with the type
                // of object that is being deserialized.
                mySerializer = new XmlSerializer(typeof(Cliente));
                // To read the file, create a FileStream.
                myFileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
            }
            // Call the Deserialize method and cast to the object type.
            myObject = (Cliente)mySerializer.Deserialize(myFileStream);

            Factura fact = bsFactura.Current as Factura;


            Util.CopiarPropiedadesTipo(myObject, fact);

            bsFactura.ResetCurrentItem();
        }

        private void GuardarDatosClienteToolStripMenuItemClick(object sender, EventArgs e)
        {
            Cliente myObject;
            XmlSerializer mySerializer;
            StreamWriter myWriter;
            using (SaveFileDialog sabeD = new SaveFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    Title = FacturasRecursos.Form1_guardarDatosClienteToolStripMenuItem_Click_Guardar_Datos_Cliente_como___,
                    Filter = FacturasRecursos.Form1_guardarDatosClienteToolStripMenuItem_Click_Factura____upo____upo
                })
            {
                if (sabeD.ShowDialog(this) != DialogResult.OK) return;
                Factura fact = bsFactura.Current as Factura;

                myObject = new Cliente();

                Util.CopiarPropiedadesTipo(fact, myObject);

                // Insert code to set properties and fields of the object.
                mySerializer = new XmlSerializer(typeof(Cliente));
                // To write to a file, create a StreamWriter object.
                myWriter = new StreamWriter(sabeD.FileName);
            }
            mySerializer.Serialize(myWriter, myObject);
            myWriter.Close();
        }

        private void ToolStripButtonInsertarClick(object sender, EventArgs e)
        {
            if (!DatosLineaValido()) return;
            ActualizarContadoresLineas();

            Factura c = bsFactura.Current as Factura;

            LineaFactura nl = new LineaFactura
                {
                    HorasEuros = Settings.Default.eurosXHora,
                    KilometrosEuros = Settings.Default.eurosXKilometros,
                    Concepto = string.Empty
                };

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
        private void ToolStripButtonEliminarClick(object sender, EventArgs e)
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

        private void ToolStripButtonSiguienteClick(object sender, EventArgs e)
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

        private void ToolStripButtonAnteriorClick(object sender, EventArgs e)
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

        private void ToolStripButtonUltimoClick(object sender, EventArgs e)
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

        private void ToolStripButtonPrimeroClick(object sender, EventArgs e)
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

        private void CodigoPostalTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void CantidadTextBoxEnter(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            if (t != null) t.SelectAll();
        }

        private void CodigoPostalTextBoxValidating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            int valor;


            if (tb != null && !string.IsNullOrEmpty(tb.Text))
            {
                errorProvider1.SetError(tb, string.Empty);
                if (!int.TryParse(tb.Text, out valor))
                {
                    errorProvider1.SetError(tb, "El código postal debe ser un número entero de 5 cifras.");
                }
            }
        }

        private void CantidadTextBoxValidating(object sender, CancelEventArgs e)
        {
            float cantidad;
            errorProvider1.SetError(cantidadTextBox, string.Empty);
            if (!float.TryParse(cantidadTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(cantidadTextBox, _laCantidadNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO);
            }
        }

        private void HorasEsperaTextBoxValidating(object sender, CancelEventArgs e)
        {
            float cantidad;


            if (!float.TryParse(horasEsperaTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(horasEsperaTextBox, _lasHorasDeEsperaNoEsCorrectaPorFavorIntroduceUnaCanidadEnEurosO);
            }
        }

        private void KilometrosTextBoxValidating(object sender, CancelEventArgs e)
        {
            float cantidad;

            if (!float.TryParse(kilometrosTextBox.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(kilometrosTextBox, _losCkilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
            }
        }

        private void TxtHorasEurosValidating(object sender, CancelEventArgs e)
        {
            float cantidad;
            if (!float.TryParse(txtHorasEuros.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(txtHorasEuros, _elPrecioDeLasHorasDeEsperaNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
            }

        }

        private void TxtKilomestrosEurosValidating(object sender, CancelEventArgs e)
        {
            float cantidad;
            if (!float.TryParse(txtKilomestrosEuros.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture.NumberFormat, out cantidad))
            {
                errorProvider1.SetError(txtKilomestrosEuros, _elPrecioDeLosKilometrosNoEsCorrectoPorFavorIntroduceUnaCanidadEnEurosO);
            }
        }


    }
}
