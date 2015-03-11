using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace Facturas
{
    public partial class UcPreview : DevExpress.XtraEditors.XtraUserControl
    {
        private XtraReport _report;

        #region Propiedades

        public RibbonControl RibbonControl { get { return ribbonControl1; } }

        public XtraReport Report
        {
            get { return _report; }
            set
            {
                _report = value;
                documentViewer1.DocumentSource = value;

                documentViewer1.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Customize, CommandVisibility.None);

                documentViewer1.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Parameters, CommandVisibility.None);
            }
        }

        #endregion

        public UcPreview()
        {
            InitializeComponent();

            
        }
    }
}
