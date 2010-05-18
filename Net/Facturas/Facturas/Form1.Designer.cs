
using Facturas.BizzRules;
namespace Facturas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label conceptoLabel;
            System.Windows.Forms.Label horasEsperaLabel;
            System.Windows.Forms.Label kilometrosLabel;
            System.Windows.Forms.Label cifLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.bsLineas = new System.Windows.Forms.BindingSource(this.components);
            this.conceptoTextBox = new System.Windows.Forms.TextBox();
            this.horasEsperaTextBox = new System.Windows.Forms.TextBox();
            this.kilometrosTextBox = new System.Windows.Forms.TextBox();
            this.cifTextBox = new System.Windows.Forms.TextBox();
            this.bsFactura = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.codigoPostalTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbLineas = new System.Windows.Forms.GroupBox();
            this.txtKilomestrosEuros = new System.Windows.Forms.TextBox();
            this.txtHorasEuros = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGenerar = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDatosClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarDatosClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.generarFicheroFacturaPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPrimero = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxActual = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSiguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonInsertar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            cantidadLabel = new System.Windows.Forms.Label();
            conceptoLabel = new System.Windows.Forms.Label();
            horasEsperaLabel = new System.Windows.Forms.Label();
            kilometrosLabel = new System.Windows.Forms.Label();
            cifLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbLineas.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(20, 22);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 2;
            cantidadLabel.Text = "Cantidad:";
            // 
            // conceptoLabel
            // 
            conceptoLabel.AutoSize = true;
            conceptoLabel.Location = new System.Drawing.Point(16, 48);
            conceptoLabel.Name = "conceptoLabel";
            conceptoLabel.Size = new System.Drawing.Size(56, 13);
            conceptoLabel.TabIndex = 4;
            conceptoLabel.Text = "Concepto:";
            // 
            // horasEsperaLabel
            // 
            horasEsperaLabel.AutoSize = true;
            horasEsperaLabel.Location = new System.Drawing.Point(147, 22);
            horasEsperaLabel.Name = "horasEsperaLabel";
            horasEsperaLabel.Size = new System.Drawing.Size(74, 13);
            horasEsperaLabel.TabIndex = 6;
            horasEsperaLabel.Text = "Horas Espera:";
            // 
            // kilometrosLabel
            // 
            kilometrosLabel.AutoSize = true;
            kilometrosLabel.Location = new System.Drawing.Point(296, 22);
            kilometrosLabel.Name = "kilometrosLabel";
            kilometrosLabel.Size = new System.Drawing.Size(58, 13);
            kilometrosLabel.TabIndex = 8;
            kilometrosLabel.Text = "Kilometros:";
            // 
            // cifLabel
            // 
            cifLabel.AutoSize = true;
            cifLabel.Location = new System.Drawing.Point(9, 100);
            cifLabel.Name = "cifLabel";
            cifLabel.Size = new System.Drawing.Size(22, 13);
            cifLabel.TabIndex = 11;
            cifLabel.Text = "Cif:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(9, 212);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 13;
            ciudadLabel.Text = "Ciudad:";
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Location = new System.Drawing.Point(9, 238);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            codigoPostalLabel.TabIndex = 15;
            codigoPostalLabel.Text = "Codigo Postal:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(9, 126);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 17;
            direccionLabel.Text = "Direccion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(9, 49);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 19;
            fechaLabel.Text = "Fecha:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(9, 74);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "Nombre:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(9, 22);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 23;
            numeroLabel.Text = "Numero:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(9, 264);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 25;
            telefonoLabel.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(578, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 35;
            label1.Text = "Kilometros:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(429, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 13);
            label2.TabIndex = 34;
            label2.Text = "Horas Espera:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(78, 19);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(63, 20);
            this.cantidadTextBox.TabIndex = 0;
            this.cantidadTextBox.TextChanged += new System.EventHandler(this.txtKilomestrosEuros_TextChanged);
            // 
            // bsLineas
            // 
            this.bsLineas.DataSource = typeof(LineaFactura);
            // 
            // conceptoTextBox
            // 
            this.conceptoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.conceptoTextBox.Location = new System.Drawing.Point(78, 45);
            this.conceptoTextBox.Multiline = true;
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.Size = new System.Drawing.Size(628, 145);
            this.conceptoTextBox.TabIndex = 5;
            // 
            // horasEsperaTextBox
            // 
            this.horasEsperaTextBox.Location = new System.Drawing.Point(227, 19);
            this.horasEsperaTextBox.Name = "horasEsperaTextBox";
            this.horasEsperaTextBox.Size = new System.Drawing.Size(63, 20);
            this.horasEsperaTextBox.TabIndex = 1;
            this.horasEsperaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoPostalTextBox_KeyPress);
            // 
            // kilometrosTextBox
            // 
            this.kilometrosTextBox.Location = new System.Drawing.Point(360, 19);
            this.kilometrosTextBox.Name = "kilometrosTextBox";
            this.kilometrosTextBox.Size = new System.Drawing.Size(63, 20);
            this.kilometrosTextBox.TabIndex = 2;
            this.kilometrosTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoPostalTextBox_KeyPress);
            // 
            // cifTextBox
            // 
            this.cifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFactura, "Cif", true));
            this.cifTextBox.Location = new System.Drawing.Point(90, 97);
            this.cifTextBox.Name = "cifTextBox";
            this.cifTextBox.Size = new System.Drawing.Size(66, 20);
            this.cifTextBox.TabIndex = 3;
            this.cifTextBox.Text = "28806983N";
            // 
            // bsFactura
            // 
            this.bsFactura.DataSource = typeof(Factura);
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFactura, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(90, 209);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(616, 20);
            this.ciudadTextBox.TabIndex = 5;
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFactura, "CodigoPostal", true));
            this.codigoPostalTextBox.Location = new System.Drawing.Point(90, 235);
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(66, 20);
            this.codigoPostalTextBox.TabIndex = 6;
            this.codigoPostalTextBox.Text = "41089";
            this.codigoPostalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoPostalTextBox_KeyPress);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFactura, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(90, 123);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(616, 81);
            this.direccionTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFactura, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(90, 71);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(616, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFactura, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(90, 19);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(66, 20);
            this.numeroTextBox.TabIndex = 0;
            this.numeroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoPostalTextBox_KeyPress);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFactura, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(90, 261);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(66, 20);
            this.telefonoTextBox.TabIndex = 7;
            this.telefonoTextBox.Text = "954120606";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(cifLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Controls.Add(this.cifTextBox);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(ciudadLabel);
            this.groupBox1.Controls.Add(this.numeroTextBox);
            this.groupBox1.Controls.Add(this.ciudadTextBox);
            this.groupBox1.Controls.Add(numeroLabel);
            this.groupBox1.Controls.Add(codigoPostalLabel);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.codigoPostalTextBox);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFactura, "Fecha", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.textBox1.Location = new System.Drawing.Point(90, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 1;
            // 
            // gbLineas
            // 
            this.gbLineas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLineas.Controls.Add(this.txtKilomestrosEuros);
            this.gbLineas.Controls.Add(this.conceptoTextBox);
            this.gbLineas.Controls.Add(label1);
            this.gbLineas.Controls.Add(this.kilometrosTextBox);
            this.gbLineas.Controls.Add(this.txtHorasEuros);
            this.gbLineas.Controls.Add(kilometrosLabel);
            this.gbLineas.Controls.Add(label2);
            this.gbLineas.Controls.Add(cantidadLabel);
            this.gbLineas.Controls.Add(this.horasEsperaTextBox);
            this.gbLineas.Controls.Add(this.cantidadTextBox);
            this.gbLineas.Controls.Add(horasEsperaLabel);
            this.gbLineas.Controls.Add(conceptoLabel);
            this.gbLineas.Enabled = false;
            this.gbLineas.Location = new System.Drawing.Point(3, 3);
            this.gbLineas.Name = "gbLineas";
            this.gbLineas.Size = new System.Drawing.Size(714, 196);
            this.gbLineas.TabIndex = 0;
            this.gbLineas.TabStop = false;
            this.gbLineas.Text = "Líneas de factura";
            // 
            // txtKilomestrosEuros
            // 
            this.txtKilomestrosEuros.Location = new System.Drawing.Point(642, 19);
            this.txtKilomestrosEuros.Name = "txtKilomestrosEuros";
            this.txtKilomestrosEuros.Size = new System.Drawing.Size(63, 20);
            this.txtKilomestrosEuros.TabIndex = 4;
            this.txtKilomestrosEuros.TextChanged += new System.EventHandler(this.txtKilomestrosEuros_TextChanged);
            // 
            // txtHorasEuros
            // 
            this.txtHorasEuros.Location = new System.Drawing.Point(509, 19);
            this.txtHorasEuros.Name = "txtHorasEuros";
            this.txtHorasEuros.Size = new System.Drawing.Size(63, 20);
            this.txtHorasEuros.TabIndex = 3;
            this.txtHorasEuros.TextChanged += new System.EventHandler(this.txtKilomestrosEuros_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNuevo,
            this.toolStripButtonGuardar,
            this.toolStripButtonGenerar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNuevo
            // 
            this.toolStripButtonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNuevo.Image = global::Facturas.Facturas.nuevo;
            this.toolStripButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevo.Name = "toolStripButtonNuevo";
            this.toolStripButtonNuevo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNuevo.Text = "toolStripButton1";
            this.toolStripButtonNuevo.Click += new System.EventHandler(this.toolStripButtonNuevo_Click);
            // 
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuardar.Image")));
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGuardar.Text = "toolStripButton1";
            // 
            // toolStripButtonGenerar
            // 
            this.toolStripButtonGenerar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGenerar.Image = global::Facturas.Facturas.page;
            this.toolStripButtonGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerar.Name = "toolStripButtonGenerar";
            this.toolStripButtonGenerar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGenerar.Text = "toolStripButton1";
            this.toolStripButtonGenerar.Click += new System.EventHandler(this.toolStripButtonGenerar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoFacturaToolStripMenuItem,
            this.cargarFacturaToolStripMenuItem,
            this.guardarFacturaToolStripMenuItem,
            this.cargarDatosClienteToolStripMenuItem,
            this.guardarDatosClienteToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoFacturaToolStripMenuItem
            // 
            this.nuevoFacturaToolStripMenuItem.Image = global::Facturas.Facturas.nuevo;
            this.nuevoFacturaToolStripMenuItem.Name = "nuevoFacturaToolStripMenuItem";
            this.nuevoFacturaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nuevoFacturaToolStripMenuItem.Text = "Nueva Factura";
            this.nuevoFacturaToolStripMenuItem.Click += new System.EventHandler(this.nuevoFacturaToolStripMenuItem_Click);
            // 
            // cargarFacturaToolStripMenuItem
            // 
            this.cargarFacturaToolStripMenuItem.Name = "cargarFacturaToolStripMenuItem";
            this.cargarFacturaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cargarFacturaToolStripMenuItem.Text = "Cargar Factura";
            this.cargarFacturaToolStripMenuItem.Click += new System.EventHandler(this.cargarFacturaToolStripMenuItem_Click);
            // 
            // guardarFacturaToolStripMenuItem
            // 
            this.guardarFacturaToolStripMenuItem.Image = global::Facturas.Facturas.save;
            this.guardarFacturaToolStripMenuItem.Name = "guardarFacturaToolStripMenuItem";
            this.guardarFacturaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.guardarFacturaToolStripMenuItem.Text = "&Guardar Factura";
            this.guardarFacturaToolStripMenuItem.Click += new System.EventHandler(this.guardarFacturaToolStripMenuItem_Click);
            // 
            // cargarDatosClienteToolStripMenuItem
            // 
            this.cargarDatosClienteToolStripMenuItem.Name = "cargarDatosClienteToolStripMenuItem";
            this.cargarDatosClienteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cargarDatosClienteToolStripMenuItem.Text = "Cargar Datos Cliente";
            this.cargarDatosClienteToolStripMenuItem.Click += new System.EventHandler(this.cargarDatosClienteToolStripMenuItem_Click);
            // 
            // guardarDatosClienteToolStripMenuItem
            // 
            this.guardarDatosClienteToolStripMenuItem.Image = global::Facturas.Facturas.save;
            this.guardarDatosClienteToolStripMenuItem.Name = "guardarDatosClienteToolStripMenuItem";
            this.guardarDatosClienteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.guardarDatosClienteToolStripMenuItem.Text = "Guardar Datos Cliente";
            this.guardarDatosClienteToolStripMenuItem.Click += new System.EventHandler(this.guardarDatosClienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Facturas.Facturas.sout;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarDatosClienteToolStripMenuItem,
            this.toolStripSeparator2,
            this.generarFicheroFacturaPDFToolStripMenuItem,
            this.firmarFacturaToolStripMenuItem,
            this.toolStripSeparator3,
            this.configurarToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // limpiarDatosClienteToolStripMenuItem
            // 
            this.limpiarDatosClienteToolStripMenuItem.Name = "limpiarDatosClienteToolStripMenuItem";
            this.limpiarDatosClienteToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.limpiarDatosClienteToolStripMenuItem.Text = "Limpiar Datos Cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // generarFicheroFacturaPDFToolStripMenuItem
            // 
            this.generarFicheroFacturaPDFToolStripMenuItem.Image = global::Facturas.Facturas.page;
            this.generarFicheroFacturaPDFToolStripMenuItem.Name = "generarFicheroFacturaPDFToolStripMenuItem";
            this.generarFicheroFacturaPDFToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.generarFicheroFacturaPDFToolStripMenuItem.Text = "Generar Fichero Factura PDF";
            this.generarFicheroFacturaPDFToolStripMenuItem.Click += new System.EventHandler(this.generarFicheroFacturaPDFToolStripMenuItem_Click);
            // 
            // firmarFacturaToolStripMenuItem
            // 
            this.firmarFacturaToolStripMenuItem.Image = global::Facturas.Facturas.sign;
            this.firmarFacturaToolStripMenuItem.Name = "firmarFacturaToolStripMenuItem";
            this.firmarFacturaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.firmarFacturaToolStripMenuItem.Text = "Firmar Factura";
            this.firmarFacturaToolStripMenuItem.Click += new System.EventHandler(this.firmarFacturaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Image = global::Facturas.Facturas.lin_agt_wrench;
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.configurarToolStripMenuItem.Text = "Configurar";
            this.configurarToolStripMenuItem.Click += new System.EventHandler(this.configurarToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 52);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbLineas);
            this.splitContainer1.Size = new System.Drawing.Size(720, 500);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 31;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrimero,
            this.toolStripButtonAnterior,
            this.toolStripSeparator4,
            this.toolStripTextBoxActual,
            this.toolStripLabelTotal,
            this.toolStripSeparator5,
            this.toolStripButtonSiguiente,
            this.toolStripButtonUltimo,
            this.toolStripSeparator6,
            this.toolStripButtonInsertar,
            this.toolStripButtonEliminar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 555);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(744, 25);
            this.toolStrip2.TabIndex = 32;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonPrimero
            // 
            this.toolStripButtonPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrimero.Image = global::Facturas.Facturas.BindingNavigatorSkin_NavigateEndRTL;
            this.toolStripButtonPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrimero.Name = "toolStripButtonPrimero";
            this.toolStripButtonPrimero.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrimero.Text = "Primera Línea";
            this.toolStripButtonPrimero.Click += new System.EventHandler(this.toolStripButtonPrimero_Click);
            // 
            // toolStripButtonAnterior
            // 
            this.toolStripButtonAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAnterior.Image = global::Facturas.Facturas.BindingNavigatorSkin_NavigateNextRTL;
            this.toolStripButtonAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnterior.Name = "toolStripButtonAnterior";
            this.toolStripButtonAnterior.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAnterior.Text = "Línea Anterior";
            this.toolStripButtonAnterior.Click += new System.EventHandler(this.toolStripButtonAnterior_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxActual
            // 
            this.toolStripTextBoxActual.Name = "toolStripTextBoxActual";
            this.toolStripTextBoxActual.Size = new System.Drawing.Size(50, 25);
            // 
            // toolStripLabelTotal
            // 
            this.toolStripLabelTotal.Name = "toolStripLabelTotal";
            this.toolStripLabelTotal.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSiguiente
            // 
            this.toolStripButtonSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSiguiente.Image = global::Facturas.Facturas.BindingNavigatorSkin_NavigateNextLTR;
            this.toolStripButtonSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSiguiente.Name = "toolStripButtonSiguiente";
            this.toolStripButtonSiguiente.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSiguiente.Text = "Siguiente Línea";
            this.toolStripButtonSiguiente.Click += new System.EventHandler(this.toolStripButtonSiguiente_Click);
            // 
            // toolStripButtonUltimo
            // 
            this.toolStripButtonUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUltimo.Image = global::Facturas.Facturas.BindingNavigatorSkin_NavigateEndLTR;
            this.toolStripButtonUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUltimo.Name = "toolStripButtonUltimo";
            this.toolStripButtonUltimo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUltimo.Text = "ültima línea";
            this.toolStripButtonUltimo.Click += new System.EventHandler(this.toolStripButtonUltimo_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonInsertar
            // 
            this.toolStripButtonInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInsertar.Image = global::Facturas.Facturas.BindingNavigatorSkin_Add;
            this.toolStripButtonInsertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertar.Name = "toolStripButtonInsertar";
            this.toolStripButtonInsertar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInsertar.Text = "Añadir Línea";
            this.toolStripButtonInsertar.Click += new System.EventHandler(this.toolStripButtonInsertar_Click);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = global::Facturas.Facturas.BindingNavigatorSkin_Delete;
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEliminar.Text = "Eliminar Línea";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 580);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(752, 614);
            this.Name = "Form1";
            this.Text = "Facturas Taxi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbLineas.ResumeLayout(false);
            this.gbLineas.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsLineas;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox conceptoTextBox;
        private System.Windows.Forms.TextBox horasEsperaTextBox;
        private System.Windows.Forms.TextBox kilometrosTextBox;
        private System.Windows.Forms.BindingSource bsFactura;
        private System.Windows.Forms.TextBox cifTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox codigoPostalTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbLineas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarDatosClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem generarFicheroFacturaPDFToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerar;
        private System.Windows.Forms.ToolStripMenuItem firmarFacturaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtKilomestrosEuros;
        private System.Windows.Forms.TextBox txtHorasEuros;
        private System.Windows.Forms.ToolStripMenuItem cargarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrimero;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnterior;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxActual;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTotal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonSiguiente;
        private System.Windows.Forms.ToolStripButton toolStripButtonUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
    }
}

