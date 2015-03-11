using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Facturas
{
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Atributos


        private int _current = -1;

        private readonly DatosFactura _datosFactura = new DatosFactura
        {
            Enabled = false
        };

        private readonly Configuracion _configuracion = new Configuracion();

        private UcPreview _preview = new UcPreview();
        private bool _puedeGenerarReport;

        #endregion

        #region Propiedades

        private bool PuedeGenerarReport
        {
            get { return _puedeGenerarReport; }
            set
            {
                _puedeGenerarReport = value;
                barButtonItemCargarCliente.Enabled = value;
                barButtonItemGuardar.Enabled = value;
                barButtonItemGuardarFactura.Enabled = value;
            }
        }

        public XtraUserControl CurrentControl { get; set; }

        #endregion

        #region Constructores

        public Principal()
        {
            InitializeComponent();

            PuedeGenerarReport = false;
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

            PuedeGenerarReport = true;
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
            if (PuedeGenerarReport && Equals(ribbon.SelectedPage, ribbonPageImpresion))
            {
                _preview = new UcPreview
                {
                    Report = _datosFactura.CreateReportFactura()
                };

                CambiarDetalle(_preview);

                ribbon.MergeRibbon(_preview.RibbonControl);

                return;
            }
            if (Equals(ribbon.SelectedPage, ribbonPageConfiguracion))
            {
                CambiarDetalle(_configuracion);

                return;
            }
        }

        private void ribbon_SelectedPageChanging(object sender, DevExpress.XtraBars.Ribbon.RibbonPageChangingEventArgs e)
        {
            if (Equals(e.Page, ribbonPageImpresion))
            {
                e.Cancel = !PuedeGenerarReport;
            }
        }

        private void barButtonItemGuardarConfiguracion_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Equals(ribbon.SelectedPage, ribbonPageConfiguracion) && Equals(CurrentControl, _configuracion))
            {
                _configuracion.Guardar();
            }
        }




    }
}