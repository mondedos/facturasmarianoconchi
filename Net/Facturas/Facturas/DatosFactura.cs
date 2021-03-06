﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Facturas.BizzRules;
using Facturas.Properties;
using Facturas.Report;

namespace Facturas
{
    public partial class DatosFactura : XtraUserControl
    {
        #region Atributos

        #endregion

        #region Propiedades

        public Factura Factura
        {
            get { return bsFactura.Current as Factura; }
            set
            {
                bsFactura.DataSource = value;
                bsLineas.DataSource = value.Lineas;
            }
        }

        public Cliente Cliente
        {
            get { return bsCliente.Current as Cliente; }
            set
            {
                bsCliente.DataSource = value;
            }
        }

        #endregion

        #region Constructores

        public DatosFactura()
        {
            InitializeComponent();

            gridView1.OptionsEditForm.CustomEditFormLayout = new UcLinea();
            gridView1.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplaceHideCurrentRow;
        }

        #endregion

        #region Metodos

        public void CargarDatosCliente()
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

            Cliente = myObject;

            bsFactura.ResetCurrentItem();
        }

        public void GuardarDatosCliente()
        {
            Cliente myObject = Cliente ?? new Cliente();

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


                Util.CopiarPropiedadesTipo(fact, myObject);

                // Insert code to set properties and fields of the object.
                mySerializer = new XmlSerializer(typeof(Cliente));
                // To write to a file, create a StreamWriter object.
                myWriter = new StreamWriter(sabeD.FileName);
            }
            mySerializer.Serialize(myWriter, myObject);
            myWriter.Close();

            Cliente = myObject;
        }

        public void Disenyar()
        {
            Factura factura = bsFactura.Current as Factura;

            if (factura != null)
            {
                var cliente = Cliente ?? new Cliente();

                XtraReportFactura xtraReport = new XtraReportFactura
                {
                    Factura = factura
                };

                try
                {
                    using (var ms = new MemoryStream(cliente.ModeloDocumento))
                    {
                        ms.Position = 0;

                        xtraReport.LoadLayout(ms);
                    }
                }
                catch (Exception)
                {
                }


                ReportDesignTool dt = new ReportDesignTool(xtraReport);

                // Invoke the Ribbon End-User Designer form modally. 
                dt.ShowRibbonDesignerDialog();

                using (var ms = new MemoryStream())
                {
                    xtraReport.SaveLayout(ms);

                    ms.Position = 0;

                    cliente.ModeloDocumento = ms.ToArray();
                }
            }

        }

        public Factura NuevaFactura()
        {
            bsFactura.EndEdit();
            bsFactura.List.Clear();
            bsFactura.AddNew();

            HabilitarGenerar(false);

            return Factura;
        }


        private void HabilitarGenerar(bool value)
        {
            //generarFicheroFacturaPDFToolStripMenuItem.Enabled = value;
            //toolStripButtonGenerar.Enabled = value;
            //guardarFacturaToolStripMenuItem.Enabled = value;
        }

        public void SetTextWatermark(XtraReport report)
        {
            // Adjust text watermark settings.
            string textoFirma = Settings.Default.TextoFirma;

            if (string.IsNullOrWhiteSpace(textoFirma)) return;

            report.Watermark.Text = textoFirma;
            report.Watermark.TextDirection = DirectionMode.ForwardDiagonal;
            report.Watermark.Font = new Font(report.Watermark.Font.FontFamily, 40);
            report.Watermark.ForeColor = Color.DodgerBlue;
            report.Watermark.TextTransparency = 150;
            report.Watermark.ShowBehind = false;
            //report.Watermark.PageRange = "1,3-5";
        }

        public XtraReportFactura CreateReportFactura()
        {
            var xtraReport = CalcularReport();

            using (var ms = new MemoryStream())
            {
                xtraReport.ExportToText(ms);

                ms.Position = 0;

                xtraReport = CalcularReport();

                using (var sw = new StreamReader(ms))
                {
                    xtraReport.Parameters["firma"].Value = Factura.GetSha1(sw.ReadToEnd());
                }
            }

            SetTextWatermark(xtraReport);

            return xtraReport;
        }

        private XtraReportFactura CalcularReport()
        {
            Factura factura = Factura;

            factura.Lineas.Clear();
            factura.Lineas.AddRange(bsLineas.Cast<LineaFactura>());

            factura.CalcularSubtotales();

            XtraReportFactura xtraReport = new XtraReportFactura();

            var cliente = Cliente ?? new Cliente();

            try
            {
                using (var ms = new MemoryStream(cliente.ModeloDocumento))
                {
                    ms.Position = 0;

                    xtraReport.LoadLayout(ms);
                }
            }
            catch (Exception)
            {
            }

            xtraReport.Factura = factura;
            xtraReport.RequestParameters = false;

            ParameterCollection parameters = xtraReport.Parameters;

            parameters["licenciaMunicipal"].Value = Settings.Default.licencia;
            parameters["email"].Value = Settings.Default.email;
            parameters["Movil"].Value = Settings.Default.movil;
            parameters["Nif"].Value = Settings.Default.nif;
            parameters["Telefono"].Value = Settings.Default.telefono;
            parameters["nombre"].Value = Settings.Default.nombre;
            parameters["direccion"].Value = Settings.Default.direccion;
            parameters["poblacion"].Value = Settings.Default.poblacionCP;

            if (!string.IsNullOrEmpty(Settings.Default.Iban))
            {
                parameters["iban"].Value = string.Format("IBAN: {0}", Settings.Default.Iban);
            }
            else
            {
                parameters["iban"].Value = string.Format("IBAN: {0}", Settings.Default.ccc);
            }
            return xtraReport;
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
        void bsFactura_AddingNew(object sender, AddingNewEventArgs e)
        {
            Factura factura = new Factura();
            
            var cliente = Cliente;

            if (cliente != null
                && XtraMessageBox.Show(string.Format("¿Desea conservar los datos del cliente de la factura {0}?", Settings.Default.ultimaFactura)
                , "Nueva factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Util.CopiarPropiedadesTipo(cliente, factura);
            }


            e.NewObject = factura;

            factura.Fecha = DateTime.Now;
            factura.Numero = Settings.Default.ultimaFactura + 1;

            Settings.Default.ultimaFactura = factura.Numero;

            Settings.Default.Save();

            bsLineas.Clear();
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
    }
}
