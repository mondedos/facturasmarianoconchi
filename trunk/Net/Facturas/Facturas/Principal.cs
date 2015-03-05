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
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using Facturas.BizzRules;
using Facturas.Properties;
using Facturas.Report;

namespace Facturas
{
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Atributos

        private int _current = -1;

        private DatosFactura _datosFactura = new DatosFactura
        {
            Enabled = false
        };

        private Configuracion _configuracion=new Configuracion();

        private UcPreview _preview=new UcPreview();

        #endregion

        #region Propiedades

        public XtraUserControl CurrentControl { get; set; }

        #endregion

        #region Constructores

        public Principal()
        {
            InitializeComponent();
        }

        #endregion

        #region Implementacion de Eventos

        #region Botonera

        private void barButtonItemCargarCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            _datosFactura.CargarDatosCliente();
        }

        private void barButtonItemGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            _datosFactura.GuardarDatosCliente();
        }

        private void barButtonItemNuevaFactura_ItemClick(object sender, ItemClickEventArgs e)
        {
            _datosFactura.Enabled = true;
            var factura = _datosFactura.NuevaFactura();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
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
                    //Factura fact = bsFactura.Current as Factura;



                }
            }
        }
        #endregion


        #endregion

        #region Overrides of XtraForm

        /// <summary>
        /// Provoca el evento <see cref="E:System.Windows.Forms.Form.Load"/>.
        /// </summary>
        /// <param name="e"><see cref="T:System.EventArgs"/> que contiene los datos del evento. </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CambiarDetalle(_datosFactura);
        }

        #endregion

        #region Metodos
        
        private void HabilitarGenerar(bool value)
        {
            //generarFicheroFacturaPDFToolStripMenuItem.Enabled = value;
            //toolStripButtonGenerar.Enabled = value;
            //guardarFacturaToolStripMenuItem.Enabled = value;
        }

        public void SetTextWatermark(XtraReport report)
        {
            // Adjust text watermark settings.
            report.Watermark.Text = "Factura Taxi Mariano";
            report.Watermark.TextDirection = DirectionMode.ForwardDiagonal;
            report.Watermark.Font = new Font(report.Watermark.Font.FontFamily, 40);
            report.Watermark.ForeColor = Color.DodgerBlue;
            report.Watermark.TextTransparency = 150;
            report.Watermark.ShowBehind = false;
            //report.Watermark.PageRange = "1,3-5";
        }


        private void CambiarDetalle(XtraUserControl detalle)
        {

            var contenedor = panelControlContenido;

            if (transitionManager1.IsTransition)
            {
                transitionManager1.EndTransition();
            }

            transitionManager1.StartTransition(contenedor);
            try
            {
                contenedor.Controls.Clear();
                Control find = detalle;
                CurrentControl = detalle;
                find.Parent = contenedor;
                find.Dock = DockStyle.Fill;
                find.BringToFront();

            }
            finally
            {
                transitionManager1.EndTransition();
            }
        }

        #endregion

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            if (Equals(ribbon.SelectedPage, ribbonPageArchivo))
            {
                CambiarDetalle(_datosFactura);

                return;
            }
            if (Equals(ribbon.SelectedPage, ribbonPageImpresion))
            {
                _preview.Report = _datosFactura.CreateReportFactura();

                CambiarDetalle(_preview);

                return;
            }
            if (Equals(ribbon.SelectedPage, ribbonPageConfiguracion))
            {
                CambiarDetalle(_configuracion);

                return;
            }
        }




    }
}