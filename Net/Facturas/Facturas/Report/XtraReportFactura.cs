using Facturas.BizzRules;

namespace Facturas.Report
{
    public partial class XtraReportFactura : DevExpress.XtraReports.UI.XtraReport
    {
        #region Atributos

        private Factura _factura;

        #endregion

        #region Propiedades

        public Factura Factura
        {
            get { return _factura; }
            set
            {
                _factura = value;
                bsFactura.DataSource = value;
            }
        }

        #endregion

        #region Constructores

        public XtraReportFactura()
        {
            InitializeComponent();
        }

        #endregion



    }
}
