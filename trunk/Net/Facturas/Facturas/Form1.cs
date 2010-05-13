using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Facturas.BizzRules;

namespace Facturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripButtonGenerar.Text = generarFicheroFacturaPDFToolStripMenuItem.Text;
            toolStripButtonNuevo.Text = nuevoFacturaToolStripMenuItem.Text;
            //pictureBox1.Image = Base64ToImage.ConvertThis("Hola mundo");
            bsFactura.AddNew();
            bsLineas.AddNew();

        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generarFicheroFacturaPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bsFactura.EndEdit();
            Factura factura = bsFactura.Current as Factura;

            bsLineas.EndEdit();



            factura.Lineas.Clear();
            foreach (LineaFactura item in bsLineas.List)
            {
                factura.Lineas.Add(item);
            }

            (new PDFGenerador(factura)).Run();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion conf = new Configuracion();


            conf.ShowDialog();
        }

        private void nuevoFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bsFactura.EndEdit();
            bsFactura.List.Clear();
            bsFactura.AddNew();


            bsLineas.EndEdit();
            bsLineas.List.Clear();
            bsLineas.AddNew();
        }

        private void toolStripButtonGenerar_Click(object sender, EventArgs e)
        {
            generarFicheroFacturaPDFToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            nuevoFacturaToolStripMenuItem_Click(sender, e);
        }
    }
}
