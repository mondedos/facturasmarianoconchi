using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Facturas
{
    public partial class Passs : XtraForm
    {
        public Passs()
        {
            InitializeComponent();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string Password
        {
            get
            {
                return txtPass.Text;
            }
        }
    }
}
