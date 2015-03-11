using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Facturas.Properties;
using System.Globalization;

namespace Facturas
{
    public partial class Configuracion : DevExpress.XtraEditors.XtraUserControl
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

        private void DecimalesCalculadoraOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {

                e.KeyChar =
                    Convert.ToChar(
                        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            }
        }
        #endregion


        void BsConfiguracionCurrentItemChanged(object sender, EventArgs e)
        {
            if (_detectarCambios)
            {
                //btnGuardar.Enabled = true;
            }
        }
        private void InicialezeValues()
        {
            //datos personales
            Settings settings = Settings.Default;

            BizzRules.Configuracion configuracion = new BizzRules.Configuracion
                {
                    Licencia = settings.licencia,
                    Nombre = settings.nombre,
                    PoblacionCp = settings.poblacionCP,
                    Direccion = settings.direccion,
                    Telefono = settings.telefono,
                    Movil = settings.movil,
                    Email = settings.email,
                    Cif = settings.nif,
                    Ccc = settings.ccc,
                    Iban = settings.Iban,
                    Iva = settings.iva,
                    EurosKilometros = settings.eurosXKilometros,
                    EurosHora = settings.eurosXHora,

                    NilvelLmFondo = settings.nivelLMFondo,
                    TablaBorde = settings.tablaBorde,
                    UltimaFactura = settings.ultimaFactura,
                    TextoFirma = settings.TextoFirma
                };

            configuracion.PropertyChanged += ConfiguracionPropertyChanged;

            if (string.IsNullOrEmpty(settings.carpetaSalidaPDF))
            {
                settings.carpetaSalidaPDF = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                settings.Save();
            }
            txtForder.Text = settings.carpetaSalidaPDF;

            bsConfiguracion.DataSource = configuracion;
        }

        void ConfiguracionPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (_detectarCambios)
            {
                //btnGuardar.Enabled = true;
            }
        }

        private void PrivateGuardar()
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;
            //datos personales
            Settings settings = Settings.Default;

            settings.licencia = configuracion.Licencia;
            settings.nombre = configuracion.Nombre;
            settings.poblacionCP = configuracion.PoblacionCp;
            settings.direccion = configuracion.Direccion;
            settings.telefono = configuracion.Telefono;
            settings.movil = configuracion.Movil;
            settings.email = configuracion.Email;
            settings.nif = configuracion.Cif;
            settings.ccc = configuracion.Ccc;
            settings.Iban = configuracion.Iban;
            settings.carpetaSalidaPDF = txtForder.Text;

            //datos económicos
            settings.iva = configuracion.Iva;
            settings.eurosXKilometros = configuracion.EurosKilometros;
            settings.eurosXHora = configuracion.EurosHora;

            settings.nivelLMFondo = configuracion.NilvelLmFondo;
            settings.tablaBorde = configuracion.TablaBorde;

            settings.ultimaFactura = configuracion.UltimaFactura;
            settings.TextoFirma = configuracion.TextoFirma;

            settings.Save();
        }
        private bool EsValido()
        {
            return !dxErrorProvider1.HasErrorsOfType(ErrorType.Critical);
        }

        private void BtnGuardarClick(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            if (!EsValido()) return;
            PrivateGuardar();
            //btnGuardar.Enabled = false;
        }


        private void BtnSalirClick(object sender, EventArgs e)
        {
            //Close();
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
            //if (!btnGuardar.Enabled) return;
            if (XtraMessageBox.Show(FacturasRecursos.Configuracion_Configuracion_FormClosing_, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

        private void TxtLicenciaEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Licencia = Convert.ToString(baseEdit.EditValue);
        }

        private void TxtNombreEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Nombre = Convert.ToString(baseEdit.EditValue);
        }

        private void TxtPoblacionEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.PoblacionCp = Convert.ToString(baseEdit.EditValue);
        }

        private void TxtDireccionEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Direccion = Convert.ToString(baseEdit.EditValue);
        }

        private void TxtTelefonoEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Telefono = Convert.ToString(baseEdit.EditValue);
        }

        private void TxtMovilEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Movil = Convert.ToString(baseEdit.EditValue);
        }

        private void TxtEmailEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Email = Convert.ToString(baseEdit.EditValue);
        }

        private void TxtNifEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Cif = Convert.ToString(baseEdit.EditValue);
        }

        private void TxtCccEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Ccc = Convert.ToString(baseEdit.EditValue);
        }

        private void TxtIvaEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Iva = Convert.ToDecimal(baseEdit.EditValue);
        }

        private void TxtHorasEsperaEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.EurosHora = Convert.ToDecimal(baseEdit.EditValue);
        }

        private void TxtKilometrosEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.EurosKilometros = Convert.ToDecimal(baseEdit.EditValue);
        }

        private void NumericUpDownNivelFondoEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.NilvelLmFondo = Convert.ToInt32(baseEdit.EditValue);
        }

        private void NumericUpDownBordeTablaEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.TablaBorde = Convert.ToInt32(baseEdit.EditValue);
        }

        private void NumericUpDownUltimaFActuraEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.UltimaFactura = Convert.ToInt32(baseEdit.EditValue);
        }

        private void TextEditIbanEditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.Iban = Convert.ToString(baseEdit.EditValue);
        }

        private void textEditTExtoFirma_EditValueChanged(object sender, EventArgs e)
        {
            BizzRules.Configuracion configuracion = bsConfiguracion.Current as BizzRules.Configuracion;

            if (configuracion == null) return;

            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            configuracion.TextoFirma = Convert.ToString(baseEdit.EditValue);


        }
    }
}
