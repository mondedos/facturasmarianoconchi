using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Facturas.Properties;
using System.Globalization;

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

            bsConfiguracion.CurrentItemChanged += BsConfiguracionCurrentItemChanged;
        }

        #endregion


        #region Metodos

        #endregion

        #region Eventos

        #endregion


        void BsConfiguracionCurrentItemChanged(object sender, EventArgs e)
        {
            if (_detectarCambios)
            {
                btnGuardar.Enabled = true;
            }
        }
        private void InicialezeValues()
        {
            //datos personales
            BizzRules.Configuracion configuracion = new BizzRules.Configuracion
                {
                    Licencia = Settings.Default.licencia,
                    Nombre = Settings.Default.nombre,
                    PoblacionCp = Settings.Default.poblacionCP,
                    Direccion = Settings.Default.direccion,
                    Telefono = Settings.Default.telefono,
                    Movil = Settings.Default.movil,
                    Email = Settings.Default.email,
                    Cif = Settings.Default.nif,
                    Ccc = Settings.Default.ccc,
                    Iva = Settings.Default.iva,
                    EurosKilometros = Settings.Default.eurosXKilometros,
                    EurosHora = Settings.Default.eurosXHora,

                    NilvelLmFondo = Settings.Default.nivelLMFondo,
                    TablaBorde = Settings.Default.tablaBorde,
                    UltimaFactura = Settings.Default.ultimaFactura
                };


            if (string.IsNullOrEmpty(Settings.Default.carpetaSalidaPDF))
            {
                Settings.Default.carpetaSalidaPDF = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                Settings.Default.Save();
            }
            txtForder.Text = Settings.Default.carpetaSalidaPDF;

            bsConfiguracion.DataSource = configuracion;
        }

        private void Guardar()
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;
            //datos personales
            Settings.Default.licencia = configuracion.Licencia;
            Settings.Default.nombre = configuracion.Nombre;
            Settings.Default.poblacionCP = configuracion.PoblacionCp;
            Settings.Default.direccion = configuracion.Direccion;
            Settings.Default.telefono = configuracion.Telefono;
            Settings.Default.movil = configuracion.Movil;
            Settings.Default.email = configuracion.Email;
            Settings.Default.nif = configuracion.Cif;
            Settings.Default.ccc = configuracion.Ccc;
            Settings.Default.carpetaSalidaPDF = txtForder.Text;

            //datos económicos
            Settings.Default.iva = configuracion.Iva;
            Settings.Default.eurosXKilometros = configuracion.EurosKilometros;
            Settings.Default.eurosXHora = configuracion.EurosHora;

            Settings.Default.nivelLMFondo = configuracion.NilvelLmFondo;
            Settings.Default.tablaBorde = configuracion.TablaBorde;

            Settings.Default.ultimaFactura = configuracion.UltimaFactura;

            Settings.Default.Save();
        }
        private bool EsValido()
        {
            return !dxErrorProvider1.HasErrorsOfType(ErrorType.Critical); 
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

        private void ConfiguracionLoad(object sender, EventArgs e)
        {
            _detectarCambios = true;
        }

        private void ConfiguracionFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnGuardar.Enabled) return;
            if (MessageBox.Show(FacturasRecursos.Configuracion_Configuracion_FormClosing_, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
