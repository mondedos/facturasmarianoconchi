using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Facturas.Report.Comands;

namespace Facturas
{
    public partial class UcPreview : DevExpress.XtraEditors.XtraUserControl
    {
        #region Atributos

        private static ExportPdfCommandHandler _exportPdfCommandHandler=new ExportPdfCommandHandler();

        private XtraReport _report;


        #endregion

        #region Propiedades

        public RibbonControl RibbonControl { get { return ribbonControl1; } }

        public XtraReport Report
        {
            get { return _report; }
            set
            {
                _report = value;
                documentViewer1.DocumentSource = value;

                PrintingSystemBase printingSystemBase = documentViewer1.PrintingSystem;

                printingSystemBase.SetCommandVisibility(PrintingSystemCommand.Customize, CommandVisibility.None);

                printingSystemBase.SetCommandVisibility(PrintingSystemCommand.Parameters, CommandVisibility.None);

                printingSystemBase.RemoveCommandHandler(_exportPdfCommandHandler);
                printingSystemBase.AddCommandHandler(_exportPdfCommandHandler);
            }
        }

        #endregion

        public UcPreview()
        {
            InitializeComponent();

            
        }
    }
}
