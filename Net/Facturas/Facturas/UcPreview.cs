using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace Facturas
{
    public partial class UcPreview : DevExpress.XtraEditors.XtraUserControl
    {
        private XtraReport _report;

        #region Propiedades

        public XtraReport Report
        {
            get { return _report; }
            set
            {
                _report = value;
                documentViewer1.DocumentSource = value;
            }
        }

        #endregion

        public UcPreview()
        {
            InitializeComponent();
        }
    }
}
