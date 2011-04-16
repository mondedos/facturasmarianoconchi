using System;
using System.Text;
using System.Windows.Forms;
using Facturas.Properties;
using System.Globalization;
using Facturas.BizzRules;

namespace Facturas
{
    public partial class Configuracion : Form
    {
        private bool _detectarCambios;
        public Configuracion()
        {
            InitializeComponent();

            InicialezeValues();


        }

        private void InicialezeValues()
        {
            //datos personales
            txtLicencia.Text = Settings.Default.licencia;
            txtNombre.Text = Settings.Default.nombre;
            txtPoblacion.Text = Settings.Default.poblacionCP;
            txtDireccion.Text = Settings.Default.direccion;
            txtTelefono.Text = Settings.Default.telefono;
            txtMovil.Text = Settings.Default.movil;
            txtEmail.Text = Settings.Default.email;
            txtNif.Text = Settings.Default.nif;
            txtCCC.Text = Settings.Default.ccc;

            if (string.IsNullOrEmpty(Settings.Default.carpetaSalidaPDF))
            {
                Settings.Default.carpetaSalidaPDF = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                Settings.Default.Save();
            }
            txtForder.Text = Settings.Default.carpetaSalidaPDF;

            //datos económicos


            txtIva.Text = Convert.ToString(Settings.Default.iva);
            txtKilometros.Text = Convert.ToString(Settings.Default.eurosXKilometros);
            txtHorasEspera.Text = Convert.ToString(Settings.Default.eurosXHora);

            numericUpDownNivelFondo.Value = Settings.Default.nivelLMFondo;
            numericUpDownBordeTabla.Value = Settings.Default.tablaBorde;
            numericUpDownUltimaFActura.Value = Convert.ToDecimal(Settings.Default.ultimaFactura);
        }

        private decimal ParsePercent(string numero)
        {
            NumberFormatInfo nfi = new NumberFormatInfo
                                       {
                                           PercentDecimalSeparator = ",",
                                           PercentSymbol = "%"
                                       };

            return decimal.Parse(numero.Replace(CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, null), NumberStyles.Any, nfi);

        }

        private void txtHorasEspera_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            float euros;

            if (tb != null)
                if (float.TryParse(tb.Text, out euros))
                {
                    tb.Text = String.Format("{0:C}", euros);
                }
        }

        private void txtIva_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            float iva;

            if (tb != null)
                if (float.TryParse(tb.Text, out iva))
                {
                    tb.Text = String.Format("{0} {1}", iva, CultureInfo.CurrentCulture.NumberFormat.PercentSymbol);
                }
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

                TextBox[] tmonedas = new TextBox[2] { txtKilometros, txtHorasEspera };

                foreach (TextBox item in tmonedas)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!EsValido()) return;
            Guardar();
            btnGuardar.Enabled = false;
        }


        private void btnSalir_Click(object sender, EventArgs e)
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

        private void numericUpDownBordeTabla_ValueChanged(object sender, EventArgs e)
        {
            if (_detectarCambios)
            {
                btnGuardar.Enabled = true;
            }
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            txtIva.TextChanged += new EventHandler(numericUpDownBordeTabla_ValueChanged);
            txtKilometros.TextChanged += new EventHandler(numericUpDownBordeTabla_ValueChanged);
            txtHorasEspera.TextChanged += new EventHandler(numericUpDownBordeTabla_ValueChanged);

            _detectarCambios = true;
        }

        private void Configuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnGuardar.Enabled) return;
            if (MessageBox.Show(Facturas.Configuracion_Configuracion_FormClosing_, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtForder.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtForder.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
