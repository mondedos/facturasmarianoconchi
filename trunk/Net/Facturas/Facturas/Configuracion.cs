using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Facturas.Properties;
using System.Globalization;
using Facturas.BizzRules;

namespace Facturas
{
    public partial class Configuracion : XtraForm
    {
        #region Atributos

        private bool _detectarCambios;

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Configuracion()
        {
            InitializeComponent();

            InicialezeValues();
        }
        #endregion


        #region Metodos

        #endregion

        #region Eventos

        #endregion
        private void InicialezeValues()
        {
            //datos personales
            txtLicencia.EditValue = Settings.Default.licencia;
            txtNombre.EditValue = Settings.Default.nombre;
            txtPoblacion.EditValue = Settings.Default.poblacionCP;
            txtDireccion.EditValue = Settings.Default.direccion;
            txtTelefono.EditValue = Settings.Default.telefono;
            txtMovil.EditValue = Settings.Default.movil;
            txtEmail.EditValue = Settings.Default.email;
            txtNif.EditValue = Settings.Default.nif;
            txtCCC.EditValue = Settings.Default.ccc;

            if (string.IsNullOrEmpty(Settings.Default.carpetaSalidaPDF))
            {
                Settings.Default.carpetaSalidaPDF = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                Settings.Default.Save();
            }
            txtForder.Text = Settings.Default.carpetaSalidaPDF;

            //datos económicos


            txtIva.EditValue = Settings.Default.iva;
            txtKilometros.EditValue = Settings.Default.eurosXKilometros;
            txtHorasEspera.EditValue = Settings.Default.eurosXHora;

            numericUpDownNivelFondo.EditValue = Settings.Default.nivelLMFondo;
            numericUpDownBordeTabla.EditValue = Settings.Default.tablaBorde;
            numericUpDownUltimaFActura.EditValue = Settings.Default.ultimaFactura;
        }

        private static decimal ParsePercent(string numero)
        {
            NumberFormatInfo nfi = new NumberFormatInfo
                                       {
                                           PercentDecimalSeparator = ",",
                                           PercentSymbol = "%"
                                       };

            return decimal.Parse(numero.Replace(CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, null), NumberStyles.Any, nfi);

        }

        private void Guardar()
        {

            //datos personales
            Settings.Default.licencia = txtLicencia.Text;
            Settings.Default.nombre = txtNombre.Text;
            Settings.Default.poblacionCP = txtPoblacion.Text;
            Settings.Default.direccion = txtDireccion.Text;
            Settings.Default.telefono = txtTelefono.Text;
            Settings.Default.movil = txtMovil.Text;
            Settings.Default.email = txtEmail.Text;
            Settings.Default.nif = txtNif.Text;
            Settings.Default.ccc = txtCCC.Text;
            Settings.Default.carpetaSalidaPDF = txtForder.Text;

            //datos económicos
            Settings.Default.iva = ParsePercent(txtIva.Text);
            Settings.Default.eurosXKilometros = decimal.Parse(txtKilometros.Text, NumberStyles.Any);
            Settings.Default.eurosXHora = decimal.Parse(txtHorasEspera.Text, NumberStyles.Any);

            Settings.Default.nivelLMFondo = Convert.ToInt32(numericUpDownNivelFondo.Value);
            Settings.Default.tablaBorde = numericUpDownBordeTabla.Value;

            Settings.Default.ultimaFactura = Convert.ToInt32(numericUpDownUltimaFActura.Value);

            Settings.Default.Save();
        }
        private bool EsValido()
        {
            errorProvider1.Clear();
            StringBuilder sb = new StringBuilder();
            foreach (Control item in gbDatosPersonales.Controls)
            {
                if (item is TextBox && item.Text.IsNullOrEmptyTrim())
                {
                    errorProvider1.SetError(item, "Falta por rellenar este dato personal.");
                    sb.AppendLine("Exiten datos Personales sin rellenar");
                    break;
                }
            }

            foreach (Control item in gbDatosEconomicos.Controls)
            {
                if (item is TextBox && item.Text.IsNullOrEmptyTrim())
                {
                    errorProvider1.SetError(item, "Falta por rellenar este dato económico.");
                    sb.AppendLine("Exiten datos Económicos sin rellenar");
                    break;
                }
            }

            if (!Convert.ToBoolean(sb.Length))
            {
                string moneda = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;

                TextEdit[] tmonedas = new [] { txtKilometros, txtHorasEspera };

                foreach (TextEdit item in tmonedas)
                {
                    //decimal.TryParse("",System.Globalization.NumberStyles.Any,
                    if (!IsNumber(item.Text.Replace(moneda, null)))
                    {
                        errorProvider1.SetError(item,"El dato económico debe estar correctamente relleno.");
                        sb.AppendLine("Asegurese que los datos económicos están correctamente rellenos");
                    }
                }
            }

            try
            {
                if (!CuentaBancariaValidador.ValidaCuentaBancaria(txtCCC.Text))
                {
                    errorProvider1.SetError(txtCCC, "La cuenta Bancaria Introducida no es válida");
                    sb.AppendLine("La cuenta Bancaria Introducida no es válida");
                }
            }
            catch (ArgumentException ex)
            {
                sb.AppendLine(ex.Message);
            }

            if (Convert.ToBoolean(sb.Length))
            {
                try
                {
                    if (!CifNifValidador.ValidarCifNifNie(txtNif.Text))
                    {
                        errorProvider1.SetError(txtNif, "El CIF no es válido");
                        sb.AppendLine("El CIF no es válido");
                    }
                }
                catch (ArgumentException ex)
                {
                    sb.AppendLine(ex.Message);
                }
            }

            if (Convert.ToBoolean(sb.Length))
            {
                MessageBox.Show(sb.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return !Convert.ToBoolean(sb.Length);
        }

        private void BtnGuardarClick(object sender, EventArgs e)
        {
            if (!EsValido()) return;
            Guardar();
            btnGuardar.Enabled = false;
        }


        private void BtnSalirClick(object sender, EventArgs e)
        {
            Close();
        }


        private static readonly System.Text.RegularExpressions.Regex _isNumber = new System.Text.RegularExpressions.Regex(@"^\d+$");

        public static bool IsInteger(string theValue)
        {
            System.Text.RegularExpressions.Match m = _isNumber.Match(theValue);
            return m.Success;
        } //IsInteger

        public static bool IsNumber(string text)
        {
            double numb;
            return Double.TryParse(text, NumberStyles.Any, CultureInfo.CurrentCulture.NumberFormat, out numb);
        }

        private void NumericUpDownBordeTablaValueChanged(object sender, EventArgs e)
        {
            if (_detectarCambios)
            {
                btnGuardar.Enabled = true;
            }
        }

        private void ConfiguracionLoad(object sender, EventArgs e)
        {
            txtIva.TextChanged += NumericUpDownBordeTablaValueChanged;
            txtKilometros.TextChanged += NumericUpDownBordeTablaValueChanged;
            txtHorasEspera.TextChanged += NumericUpDownBordeTablaValueChanged;

            _detectarCambios = true;
        }

        private void ConfiguracionFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnGuardar.Enabled) return;
            if (MessageBox.Show(Facturas.Configuracion_Configuracion_FormClosing_, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Button1Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtForder.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtForder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void TxtLicenciaValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if(tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes introducir un número de licencia.");
            }
        }

        private void TxtNombreValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar un nombre.");
            }
        }

        private void TxtPoblacionValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar una población.");
            }
        }

        private void TxtDireccionValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar una dirección.");
            }
        }

        private void TxtTelefonoValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar un número de teléfono.");
            }
        }

        private void TxtMovilValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar un número de teléfono movil.");
            }
        }

        private void TxtEmailValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar un email.");
            }
        }

        private void TxtNifValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar un NIF.");
            }
            if (!CifNifValidador.ValidarCifNifNie(txtNif.Text))
            {
                errorProvider1.SetError(txtNif, "El CIF no es válido");
            }
        }

        private void TxtCccValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar una cuenta bancaria.");
            }
            try
            {
                if (!CuentaBancariaValidador.ValidaCuentaBancaria(txtCCC.Text))
                {
                    errorProvider1.SetError(txtCCC, "La cuenta Bancaria Introducida no es válida");
                }
            }
            catch (ArgumentException ex)
            {
                
            }
        }

        private void TxtIvaValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar el IVA.");
            }
        }

        private void TxtHorasEsperaValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar el precio de hora de espera.");
            }
            if (!IsNumber(tb.Text.Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, null)))
            {
                errorProvider1.SetError(tb, "El dato económico debe estar correctamente relleno.");
            }
        }

        private void TxtKilometrosValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb == null) return;
            errorProvider1.SetError(tb, string.Empty);

            if (tb.Text.IsNullOrEmptyTrim())
            {
                errorProvider1.SetError(tb, "Debes indicar el precio por kilómetro.");
            }
            if (!IsNumber(tb.Text.Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, null)))
            {
                errorProvider1.SetError(tb, "El dato económico debe estar correctamente relleno.");
            }
        }
    }
}
