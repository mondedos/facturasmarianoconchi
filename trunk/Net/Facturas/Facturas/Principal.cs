using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Facturas.BizzRules;
using Facturas.Properties;
using Facturas.Report;

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

            gridView1.OptionsEditForm.CustomEditFormLayout = new UcLinea();
            gridView1.OptionsBehavior.EditingMode=GridEditingMode.EditFormInplaceHideCurrentRow;
           
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

        #region Lineas

        void bsLineas_AddingNew(object sender, AddingNewEventArgs e)
        {

            e.NewObject = new LineaFactura();

            LineaFactura linea = e.NewObject as LineaFactura;

            linea.HorasEuros = Settings.Default.eurosXHora;
            linea.KilometrosEuros = Settings.Default.eurosXKilometros;

        }

        #endregion

        #endregion

        #region Metodos

        private void CargarDatosCliente()
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

        private void GuardarDatosCliente()
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

        private void Disenyar()
        {
            Factura factura = bsFactura.Current as Factura;

            if (factura != null)
            {
                XtraReportFactura xtraReport = new XtraReportFactura
                {
                    Factura = factura
                };
                ReportDesignTool dt = new ReportDesignTool(xtraReport);

                // Invoke the Ribbon End-User Designer form modally. 
                dt.ShowRibbonDesignerDialog();
            }
            
        }

        #endregion


    }
}