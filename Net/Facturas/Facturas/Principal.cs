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
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.Numero = Convert.ToInt32(baseEdit.EditValue);

        }

        private void tbFecha_EditValueChanged(object sender, EventArgs e)
        {
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.Fecha = Convert.ToDateTime(baseEdit.EditValue);

        }

        private void nombreTextBox_EditValueChanged(object sender, EventArgs e)
        {
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.Nombre = Convert.ToString(baseEdit.EditValue);

        }

        private void cifTextBox_EditValueChanged(object sender, EventArgs e)
        {
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.Cif = Convert.ToString(baseEdit.EditValue);

        }

        private void direccionTextBox_EditValueChanged(object sender, EventArgs e)
        {
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.Direccion = Convert.ToString(baseEdit.EditValue);

        }

        private void ciudadTextBox_EditValueChanged(object sender, EventArgs e)
        {
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.Ciudad = Convert.ToString(baseEdit.EditValue);

        }

        private void codigoPostalTextBox_EditValueChanged(object sender, EventArgs e)
        {
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.CodigoPostal = Convert.ToString(baseEdit.EditValue);

        }

        private void telefonoTextBox_EditValueChanged(object sender, EventArgs e)
        {
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.Telefono = Convert.ToString(baseEdit.EditValue);

        }

        private void textEditUnidadOrganica_EditValueChanged(object sender, EventArgs e)
        {
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.UnidadOrganica = Convert.ToString(baseEdit.EditValue);

        }
        private void textEditUnidadTramitadora_EditValueChanged(object sender, EventArgs e)
        {
            BaseEdit baseEdit = sender as BaseEdit;

            if (baseEdit == null || baseEdit.EditValue == null || DBNull.Value.Equals(baseEdit.EditValue)) return;

            Factura.UnidadTramitadora = Convert.ToString(baseEdit.EditValue);

        }
        #endregion



        #endregion

        

       
    }
}