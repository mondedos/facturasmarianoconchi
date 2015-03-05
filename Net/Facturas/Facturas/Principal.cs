using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Facturas.BizzRules;

namespace Facturas
{
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        

        #region Propiedades

        public Factura Factura
        {
            get { return bsFactura.Current as Factura; }
            set { bsFactura.DataSource = value; }
        }

        #endregion

        #region Constructores

        public Principal()
        {
            InitializeComponent();
        }

        #endregion

        #region Implementacion de Eventos

        #region Cabecera

        private void numeroTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tbFecha_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cifTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void direccionTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ciudadTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void codigoPostalTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void telefonoTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }

        #endregion



        #endregion

       
    }
}