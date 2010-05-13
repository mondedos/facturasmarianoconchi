using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Facturas.Properties;

namespace Facturas
{
    public partial class Configuracion : Form
    {
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

            //datos económicos
            txtIva.Text = Convert.ToString(Settings.Default.iva);
            Settings.Default.eurosXKilometros = decimal.Parse(txtKilometros.Text, System.Globalization.NumberStyles.Any);
            Settings.Default.eurosXHora = decimal.Parse(txtHorasEspera.Text, System.Globalization.NumberStyles.Any);
           
        }

        private void txtHorasEspera_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            decimal iv = decimal.Parse(tb.Text, System.Globalization.NumberStyles.Any);
            float euros;

            if (float.TryParse(tb.Text, out euros))
            {
                tb.Text = String.Format("{0:C}", euros);
            }

        }

        private void txtIva_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            //decimal iv = decimal.Parse(tb.Text, System.Globalization.NumberStyles.Any);
            float iva;

            if (float.TryParse(tb.Text, out iva))
            {
                tb.Text = String.Format("{0} %", iva);
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


            throw new NotImplementedException();
            //datos económicos
            txtIva.Text = Convert.ToString(Settings.Default.iva);
            txtKilometros.Text = Convert.ToString(Settings.Default.eurosXKilometros);
            txtHorasEspera.Text = Convert.ToString(Settings.Default.eurosXHora);
        }
        private bool EsValido()
        {
            return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {
                Guardar();
            }
            else
            {
                MessageBox.Show("Revise los datos, existen datos que no son válidos.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
