
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
            this.cifTextBox = new DevExpress.XtraEditors.TextEdit();
            this.ciudadTextBox = new DevExpress.XtraEditors.TextEdit();
            this.codigoPostalTextBox = new DevExpress.XtraEditors.TextEdit();
            this.nombreTextBox = new DevExpress.XtraEditors.TextEdit();
            this.telefonoTextBox = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.numeroTextBox = new DevExpress.XtraEditors.SpinEdit();
            this.direccionTextBox = new DevExpress.XtraEditors.MemoEdit();
            this.tbFecha = new DevExpress.XtraEditors.DateEdit();
            this.gbLineas = new DevExpress.XtraEditors.GroupControl();
            this.txtKilomestrosEuros = new DevExpress.XtraEditors.TextEdit();
            this.conceptoTextBox = new DevExpress.XtraEditors.MemoEdit();
            this.txtHorasEuros = new DevExpress.XtraEditors.TextEdit();
            this.kilometrosTextBox = new DevExpress.XtraEditors.SpinEdit();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.horasEsperaTextBox = new DevExpress.XtraEditors.TextEdit();
            this.cantidadTextBox = new DevExpress.XtraEditors.TextEdit();
            this.bsFactura = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.cifTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPostalTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbLineas)).BeginInit();
            this.gbLineas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilomestrosEuros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorasEuros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kilometrosTextBox.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasEsperaTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(20, 27);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(54, 13);
            cantidadLabel.TabIndex = 2;
            cantidadLabel.Text = "Cantidad:";
            // 
            // conceptoLabel
            // 
            conceptoLabel.AutoSize = true;
            conceptoLabel.Location = new System.Drawing.Point(17, 53);
            conceptoLabel.Name = "conceptoLabel";
            conceptoLabel.Size = new System.Drawing.Size(57, 13);
            conceptoLabel.TabIndex = 4;
            conceptoLabel.Text = "Concepto:";
            // 
            // horasEsperaLabel
            // 
            horasEsperaLabel.AutoSize = true;
            horasEsperaLabel.Location = new System.Drawing.Point(166, 27);
            horasEsperaLabel.Name = "horasEsperaLabel";
            horasEsperaLabel.Size = new System.Drawing.Size(75, 13);
            horasEsperaLabel.TabIndex = 6;
            horasEsperaLabel.Text = "Horas Espera:";
            // 
            // kilometrosLabel
            // 
            kilometrosLabel.AutoSize = true;
            kilometrosLabel.Location = new System.Drawing.Point(336, 27);
            kilometrosLabel.Name = "kilometrosLabel";
            kilometrosLabel.Size = new System.Drawing.Size(60, 13);
            kilometrosLabel.TabIndex = 8;
            kilometrosLabel.Text = "Kilometros:";
            // 
            // cifLabel
            // 
            cifLabel.AutoSize = true;
            cifLabel.Location = new System.Drawing.Point(9, 105);
            cifLabel.Name = "cifLabel";
            cifLabel.Size = new System.Drawing.Size(24, 13);
            cifLabel.TabIndex = 11;
            cifLabel.Text = "Cif:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(9, 212);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(44, 13);
            ciudadLabel.TabIndex = 13;
            ciudadLabel.Text = "Ciudad:";
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Location = new System.Drawing.Point(9, 238);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(76, 13);
            codigoPostalLabel.TabIndex = 15;
            codigoPostalLabel.Text = "Codigo Postal:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(9, 131);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(54, 13);
            direccionLabel.TabIndex = 17;
            direccionLabel.Text = "Direccion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(9, 54);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 19;
            fechaLabel.Text = "Fecha:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(9, 79);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(48, 13);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "Nombre:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(9, 27);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(48, 13);
            numeroLabel.TabIndex = 23;
            numeroLabel.Text = "Numero:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(9, 264);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(53, 13);
            telefonoLabel.TabIndex = 25;
            telefonoLabel.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(666, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 13);
            label1.TabIndex = 35;
            label1.Text = "Kilometros:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(490, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 13);
            label2.TabIndex = 34;
            label2.Text = "Horas Espera:";
            // 
            // cifTextBox
            // 
            this.cifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Cif", true));
            this.cifTextBox.EditValue = "28806983N";
            this.cifTextBox.Location = new System.Drawing.Point(90, 102);
            this.cifTextBox.Name = "cifTextBox";
            this.cifTextBox.Size = new System.Drawing.Size(66, 20);
            this.cifTextBox.TabIndex = 3;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(90, 209);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(703, 20);
            this.ciudadTextBox.TabIndex = 5;
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "CodigoPostal", true));
            this.codigoPostalTextBox.EditValue = "41089";
            this.codigoPostalTextBox.Location = new System.Drawing.Point(90, 235);
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(66, 20);
            this.codigoPostalTextBox.TabIndex = 6;
            this.codigoPostalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoPostalTextBoxKeyPress);
            this.codigoPostalTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CodigoPostalTextBoxValidating);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(90, 76);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(703, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Telefono", true));
            this.telefonoTextBox.EditValue = "954120606";
            this.telefonoTextBox.Location = new System.Drawing.Point(90, 261);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(66, 20);
            this.telefonoTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(cifLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Controls.Add(this.cifTextBox);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(ciudadLabel);
            this.groupBox1.Controls.Add(this.ciudadTextBox);
            this.groupBox1.Controls.Add(numeroLabel);
            this.groupBox1.Controls.Add(codigoPostalLabel);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.codigoPostalTextBox);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.numeroTextBox);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Controls.Add(this.tbFecha);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Numero", true));
            this.numeroTextBox.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numeroTextBox.Location = new System.Drawing.Point(90, 24);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numeroTextBox.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.numeroTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.numeroTextBox.Size = new System.Drawing.Size(66, 20);
            this.numeroTextBox.TabIndex = 0;
            this.numeroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoPostalTextBoxKeyPress);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFactura, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(90, 128);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(703, 75);
            this.direccionTextBox.TabIndex = 4;
            // 
            // tbFecha
            // 
            this.tbFecha.EditValue = null;
            this.tbFecha.Location = new System.Drawing.Point(90, 50);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbFecha.Properties.Mask.EditMask = "";
            this.tbFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.tbFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbFecha.Size = new System.Drawing.Size(66, 20);
            this.tbFecha.TabIndex = 1;
            // 
            // gbLineas
            // 
            this.gbLineas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLineas.Controls.Add(this.txtKilomestrosEuros);
            this.gbLineas.Controls.Add(label1);
            this.gbLineas.Controls.Add(kilometrosLabel);
            this.gbLineas.Controls.Add(label2);
            this.gbLineas.Controls.Add(cantidadLabel);
            this.gbLineas.Controls.Add(horasEsperaLabel);
            this.gbLineas.Controls.Add(conceptoLabel);
            this.gbLineas.Controls.Add(this.conceptoTextBox);
            this.gbLineas.Controls.Add(this.txtHorasEuros);
            this.gbLineas.Controls.Add(this.kilometrosTextBox);
            this.gbLineas.Controls.Add(this.horasEsperaTextBox);
            this.gbLineas.Controls.Add(this.cantidadTextBox);
            this.gbLineas.Enabled = false;
            this.gbLineas.Location = new System.Drawing.Point(3, 3);
            this.gbLineas.Name = "gbLineas";
            this.gbLineas.Size = new System.Drawing.Size(813, 196);
            this.gbLineas.TabIndex = 0;
            this.gbLineas.Text = "Líneas de factura";
            // 
            // txtKilomestrosEuros
            // 
            this.txtKilomestrosEuros.Location = new System.Drawing.Point(731, 24);
            this.txtKilomestrosEuros.Name = "txtKilomestrosEuros";
            this.txtKilomestrosEuros.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKilomestrosEuros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtKilomestrosEuros.Properties.DisplayFormat.FormatString = "c";
            this.txtKilomestrosEuros.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKilomestrosEuros.Properties.EditFormat.FormatString = "c";
            this.txtKilomestrosEuros.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKilomestrosEuros.Size = new System.Drawing.Size(63, 20);
            this.txtKilomestrosEuros.TabIndex = 4;
            this.txtKilomestrosEuros.TextChanged += new System.EventHandler(this.TxtKilomestrosEurosTextChanged);
            this.txtKilomestrosEuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            this.txtKilomestrosEuros.Validating += new System.ComponentModel.CancelEventHandler(this.TxtKilomestrosEurosValidating);
            // 
            // conceptoTextBox
            // 
            this.conceptoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conceptoTextBox.Location = new System.Drawing.Point(79, 50);
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.Size = new System.Drawing.Size(715, 141);
            this.conceptoTextBox.TabIndex = 5;
            // 
            // txtHorasEuros
            // 
            this.txtHorasEuros.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHorasEuros.Location = new System.Drawing.Point(571, 24);
            this.txtHorasEuros.Name = "txtHorasEuros";
            this.txtHorasEuros.Properties.Appearance.Options.UseTextOptions = true;
            this.txtHorasEuros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtHorasEuros.Properties.DisplayFormat.FormatString = "c";
            this.txtHorasEuros.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHorasEuros.Properties.EditFormat.FormatString = "c";
            this.txtHorasEuros.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHorasEuros.Size = new System.Drawing.Size(63, 20);
            this.txtHorasEuros.TabIndex = 3;
            this.txtHorasEuros.TextChanged += new System.EventHandler(this.TxtKilomestrosEurosTextChanged);
            this.txtHorasEuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            this.txtHorasEuros.Validating += new System.ComponentModel.CancelEventHandler(this.TxtHorasEurosValidating);
            // 
            // kilometrosTextBox
            // 
            this.kilometrosTextBox.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kilometrosTextBox.Location = new System.Drawing.Point(401, 24);
            this.kilometrosTextBox.Name = "kilometrosTextBox";
            this.kilometrosTextBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.kilometrosTextBox.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.kilometrosTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.kilometrosTextBox.Size = new System.Drawing.Size(63, 20);
            this.kilometrosTextBox.TabIndex = 2;
            this.kilometrosTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            this.kilometrosTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.KilometrosTextBoxValidating);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNuevo,
            this.toolStripButtonGuardar,
            this.toolStripButtonGenerar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNuevo
            // 
            this.toolStripButtonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNuevo.Image = global::Facturas.FacturasRecursos.nuevo;
            this.toolStripButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevo.Name = "toolStripButtonNuevo";
            this.toolStripButtonNuevo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNuevo.Text = "toolStripButton1";
            this.toolStripButtonNuevo.Click += new System.EventHandler(this.ToolStripButtonNuevoClick);
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
            this.toolStripButtonGenerar.Image = global::Facturas.FacturasRecursos.page;
            this.toolStripButtonGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerar.Name = "toolStripButtonGenerar";
            this.toolStripButtonGenerar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGenerar.Text = "toolStripButton1";
            this.toolStripButtonGenerar.Click += new System.EventHandler(this.ToolStripButtonGenerarClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
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
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoFacturaToolStripMenuItem
            // 
            this.nuevoFacturaToolStripMenuItem.Image = global::Facturas.FacturasRecursos.nuevo;
            this.nuevoFacturaToolStripMenuItem.Name = "nuevoFacturaToolStripMenuItem";
            this.nuevoFacturaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.nuevoFacturaToolStripMenuItem.Text = "Nueva Factura";
            this.nuevoFacturaToolStripMenuItem.Click += new System.EventHandler(this.NuevoFacturaToolStripMenuItemClick);
            // 
            // cargarFacturaToolStripMenuItem
            // 
            this.cargarFacturaToolStripMenuItem.Enabled = false;
            this.cargarFacturaToolStripMenuItem.Name = "cargarFacturaToolStripMenuItem";
            this.cargarFacturaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cargarFacturaToolStripMenuItem.Text = "Cargar Factura";
            this.cargarFacturaToolStripMenuItem.Click += new System.EventHandler(this.cargarFacturaToolStripMenuItem_Click);
            // 
            // guardarFacturaToolStripMenuItem
            // 
            this.guardarFacturaToolStripMenuItem.Enabled = false;
            this.guardarFacturaToolStripMenuItem.Image = global::Facturas.FacturasRecursos.save;
            this.guardarFacturaToolStripMenuItem.Name = "guardarFacturaToolStripMenuItem";
            this.guardarFacturaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.guardarFacturaToolStripMenuItem.Text = "&Guardar Factura";
            this.guardarFacturaToolStripMenuItem.Click += new System.EventHandler(this.GuardarFacturaToolStripMenuItemClick);
            // 
            // cargarDatosClienteToolStripMenuItem
            // 
            this.cargarDatosClienteToolStripMenuItem.Name = "cargarDatosClienteToolStripMenuItem";
            this.cargarDatosClienteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cargarDatosClienteToolStripMenuItem.Text = "Cargar Datos Cliente";
            this.cargarDatosClienteToolStripMenuItem.Click += new System.EventHandler(this.CargarDatosClienteToolStripMenuItemClick);
            // 
            // guardarDatosClienteToolStripMenuItem
            // 
            this.guardarDatosClienteToolStripMenuItem.Image = global::Facturas.FacturasRecursos.save;
            this.guardarDatosClienteToolStripMenuItem.Name = "guardarDatosClienteToolStripMenuItem";
            this.guardarDatosClienteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.guardarDatosClienteToolStripMenuItem.Text = "Guardar Datos Cliente";
            this.guardarDatosClienteToolStripMenuItem.Click += new System.EventHandler(this.GuardarDatosClienteToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Facturas.FacturasRecursos.sout;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
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
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // limpiarDatosClienteToolStripMenuItem
            // 
            this.limpiarDatosClienteToolStripMenuItem.Name = "limpiarDatosClienteToolStripMenuItem";
            this.limpiarDatosClienteToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.limpiarDatosClienteToolStripMenuItem.Text = "Limpiar Datos Cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // generarFicheroFacturaPDFToolStripMenuItem
            // 
            this.generarFicheroFacturaPDFToolStripMenuItem.Image = global::Facturas.FacturasRecursos.page;
            this.generarFicheroFacturaPDFToolStripMenuItem.Name = "generarFicheroFacturaPDFToolStripMenuItem";
            this.generarFicheroFacturaPDFToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.generarFicheroFacturaPDFToolStripMenuItem.Text = "Generar Fichero Factura PDF";
            this.generarFicheroFacturaPDFToolStripMenuItem.Click += new System.EventHandler(this.GenerarFicheroFacturaPdfToolStripMenuItemClick);
            // 
            // firmarFacturaToolStripMenuItem
            // 
            this.firmarFacturaToolStripMenuItem.Image = global::Facturas.FacturasRecursos.sign;
            this.firmarFacturaToolStripMenuItem.Name = "firmarFacturaToolStripMenuItem";
            this.firmarFacturaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.firmarFacturaToolStripMenuItem.Text = "Firmar Factura";
            this.firmarFacturaToolStripMenuItem.Click += new System.EventHandler(this.FirmarFacturaToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Image = global::Facturas.FacturasRecursos.lin_agt_wrench;
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.configurarToolStripMenuItem.Text = "Configurar";
            this.configurarToolStripMenuItem.Click += new System.EventHandler(this.ConfigurarToolStripMenuItemClick);
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
            this.splitContainer1.Size = new System.Drawing.Size(819, 500);
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
            this.toolStrip2.Size = new System.Drawing.Size(843, 25);
            this.toolStrip2.TabIndex = 32;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonPrimero
            // 
            this.toolStripButtonPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrimero.Image = global::Facturas.FacturasRecursos.first_img;
            this.toolStripButtonPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrimero.Name = "toolStripButtonPrimero";
            this.toolStripButtonPrimero.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrimero.Text = "Primera Línea";
            this.toolStripButtonPrimero.Click += new System.EventHandler(this.ToolStripButtonPrimeroClick);
            // 
            // toolStripButtonAnterior
            // 
            this.toolStripButtonAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAnterior.Image = global::Facturas.FacturasRecursos.prev;
            this.toolStripButtonAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnterior.Name = "toolStripButtonAnterior";
            this.toolStripButtonAnterior.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAnterior.Text = "Línea Anterior";
            this.toolStripButtonAnterior.Click += new System.EventHandler(this.ToolStripButtonAnteriorClick);
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
            this.toolStripButtonSiguiente.Image = global::Facturas.FacturasRecursos.next;
            this.toolStripButtonSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSiguiente.Name = "toolStripButtonSiguiente";
            this.toolStripButtonSiguiente.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSiguiente.Text = "Siguiente Línea";
            this.toolStripButtonSiguiente.Click += new System.EventHandler(this.ToolStripButtonSiguienteClick);
            // 
            // toolStripButtonUltimo
            // 
            this.toolStripButtonUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUltimo.Image = global::Facturas.FacturasRecursos.last_img;
            this.toolStripButtonUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUltimo.Name = "toolStripButtonUltimo";
            this.toolStripButtonUltimo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUltimo.Text = "ültima línea";
            this.toolStripButtonUltimo.Click += new System.EventHandler(this.ToolStripButtonUltimoClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonInsertar
            // 
            this.toolStripButtonInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInsertar.Image = global::Facturas.FacturasRecursos.document_add;
            this.toolStripButtonInsertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertar.Name = "toolStripButtonInsertar";
            this.toolStripButtonInsertar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInsertar.Text = "Añadir Línea";
            this.toolStripButtonInsertar.Click += new System.EventHandler(this.ToolStripButtonInsertarClick);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = global::Facturas.FacturasRecursos.delete;
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEliminar.Text = "Eliminar Línea";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.ToolStripButtonEliminarClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // horasEsperaTextBox
            // 
            this.horasEsperaTextBox.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.horasEsperaTextBox.Location = new System.Drawing.Point(247, 24);
            this.horasEsperaTextBox.Name = "horasEsperaTextBox";
            this.horasEsperaTextBox.Properties.Appearance.Options.UseTextOptions = true;
            this.horasEsperaTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.horasEsperaTextBox.Properties.DisplayFormat.FormatString = "c";
            this.horasEsperaTextBox.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.horasEsperaTextBox.Properties.EditFormat.FormatString = "c";
            this.horasEsperaTextBox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.horasEsperaTextBox.Size = new System.Drawing.Size(63, 20);
            this.horasEsperaTextBox.TabIndex = 1;
            this.horasEsperaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            this.horasEsperaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HorasEsperaTextBoxValidating);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantidadTextBox.Location = new System.Drawing.Point(79, 24);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Properties.Appearance.Options.UseTextOptions = true;
            this.cantidadTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cantidadTextBox.Properties.DisplayFormat.FormatString = "c";
            this.cantidadTextBox.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantidadTextBox.Properties.EditFormat.FormatString = "c";
            this.cantidadTextBox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cantidadTextBox.Size = new System.Drawing.Size(63, 20);
            this.cantidadTextBox.TabIndex = 0;
            this.cantidadTextBox.TextChanged += new System.EventHandler(this.TxtKilomestrosEurosTextChanged);
            this.cantidadTextBox.Enter += new System.EventHandler(this.CantidadTextBoxEnter);
            this.cantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            this.cantidadTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CantidadTextBoxValidating);
            // 
            // bsFactura
            // 
            this.bsFactura.DataSource = typeof(Facturas.BizzRules.Factura);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 580);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(851, 614);
            this.Name = "Form1";
            this.Text = "Facturas Taxi";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.cifTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPostalTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbLineas)).EndInit();
            this.gbLineas.ResumeLayout(false);
            this.gbLineas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilomestrosEuros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptoTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorasEuros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kilometrosTextBox.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horasEsperaTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFactura;
        private DevExpress.XtraEditors.TextEdit cifTextBox;
        private DevExpress.XtraEditors.TextEdit ciudadTextBox;
        private DevExpress.XtraEditors.TextEdit codigoPostalTextBox;
        private DevExpress.XtraEditors.TextEdit nombreTextBox;
        private DevExpress.XtraEditors.TextEdit telefonoTextBox;
        private DevExpress.XtraEditors.GroupControl groupBox1;
        private DevExpress.XtraEditors.GroupControl gbLineas;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerar;
        private System.Windows.Forms.ToolStripMenuItem firmarFacturaToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit txtKilomestrosEuros;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SpinEdit numeroTextBox;
        private DevExpress.XtraEditors.MemoEdit direccionTextBox;
        private DevExpress.XtraEditors.MemoEdit conceptoTextBox;
        private DevExpress.XtraEditors.DateEdit tbFecha;
        private DevExpress.XtraEditors.TextEdit txtHorasEuros;
        private DevExpress.XtraEditors.SpinEdit kilometrosTextBox;
        private DevExpress.XtraEditors.TextEdit horasEsperaTextBox;
        private DevExpress.XtraEditors.TextEdit cantidadTextBox;
    }
}

