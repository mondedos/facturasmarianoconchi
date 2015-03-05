namespace Facturas
{
    partial class Configuracion
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
            this.txtLicencia = new DevExpress.XtraEditors.TextEdit();
            this.bsConfiguracion = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.txtForder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtPoblacion = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtMovil = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtNif = new DevExpress.XtraEditors.TextEdit();
            this.txtCCC = new DevExpress.XtraEditors.TextEdit();
            this.gbDatosPersonales = new DevExpress.XtraEditors.GroupControl();
            this.textEditIban = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.gbDatosEconomicos = new DevExpress.XtraEditors.GroupControl();
            this.txtKilometros = new DevExpress.XtraEditors.TextEdit();
            this.txtHorasEspera = new DevExpress.XtraEditors.TextEdit();
            this.txtIva = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.numericUpDownUltimaFActura = new DevExpress.XtraEditors.SpinEdit();
            this.numericUpDownBordeTabla = new DevExpress.XtraEditors.SpinEdit();
            this.numericUpDownNivelFondo = new DevExpress.XtraEditors.SpinEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtLicencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoblacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosPersonales)).BeginInit();
            this.gbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosEconomicos)).BeginInit();
            this.gbDatosEconomicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorasEspera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUltimaFActura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBordeTabla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelFondo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLicencia
            // 
            this.txtLicencia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Licencia", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtLicencia.Location = new System.Drawing.Point(121, 24);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(100, 20);
            this.txtLicencia.TabIndex = 0;
            this.txtLicencia.EditValueChanged += new System.EventHandler(this.TxtLicenciaEditValueChanged);
            // 
            // bsConfiguracion
            // 
            this.bsConfiguracion.DataSource = typeof(Facturas.BizzRules.Configuracion);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Carpeta No Pagada";
            // 
            // txtForder
            // 
            this.txtForder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForder.Location = new System.Drawing.Point(121, 284);
            this.txtForder.Name = "txtForder";
            this.txtForder.ReadOnly = true;
            this.txtForder.Size = new System.Drawing.Size(198, 21);
            this.txtForder.TabIndex = 9;
            this.txtForder.Text = "2106 0950 06 0286145041";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::Facturas.FacturasRecursos.explorar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(325, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Explorar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "CCC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "NIF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Móvil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Municipio y CP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Licencia Municipal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Kilómetro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Hora de espera";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "IVA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::Facturas.FacturasRecursos.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(356, 455);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 34);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Ultimo Número Factura";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Borde Tabla";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "LM Fondo Nivel";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtNombre.Location = new System.Drawing.Point(121, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(285, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.EditValueChanged += new System.EventHandler(this.TxtNombreEditValueChanged);
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoblacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "PoblacionCp", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtPoblacion.Location = new System.Drawing.Point(121, 76);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(285, 20);
            this.txtPoblacion.TabIndex = 2;
            this.txtPoblacion.EditValueChanged += new System.EventHandler(this.TxtPoblacionEditValueChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Direccion", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtDireccion.Location = new System.Drawing.Point(121, 102);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(285, 20);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.EditValueChanged += new System.EventHandler(this.TxtDireccionEditValueChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Telefono", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTelefono.Location = new System.Drawing.Point(121, 128);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.MaxLength = 9;
            this.txtTelefono.Size = new System.Drawing.Size(61, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.EditValueChanged += new System.EventHandler(this.TxtTelefonoEditValueChanged);
            // 
            // txtMovil
            // 
            this.txtMovil.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Movil", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtMovil.Location = new System.Drawing.Point(121, 154);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Properties.MaxLength = 9;
            this.txtMovil.Size = new System.Drawing.Size(61, 20);
            this.txtMovil.TabIndex = 5;
            this.txtMovil.EditValueChanged += new System.EventHandler(this.TxtMovilEditValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Email", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtEmail.Location = new System.Drawing.Point(121, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.EditValueChanged += new System.EventHandler(this.TxtEmailEditValueChanged);
            // 
            // txtNif
            // 
            this.txtNif.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Cif", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtNif.Location = new System.Drawing.Point(122, 206);
            this.txtNif.Name = "txtNif";
            this.txtNif.Properties.MaxLength = 9;
            this.txtNif.Size = new System.Drawing.Size(78, 20);
            this.txtNif.TabIndex = 7;
            this.txtNif.EditValueChanged += new System.EventHandler(this.TxtNifEditValueChanged);
            // 
            // txtCCC
            // 
            this.txtCCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Ccc", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCCC.Location = new System.Drawing.Point(122, 232);
            this.txtCCC.Name = "txtCCC";
            this.txtCCC.Properties.MaxLength = 20;
            this.txtCCC.Size = new System.Drawing.Size(284, 20);
            this.txtCCC.TabIndex = 8;
            this.txtCCC.EditValueChanged += new System.EventHandler(this.TxtCccEditValueChanged);
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDatosPersonales.Controls.Add(this.textEditIban);
            this.gbDatosPersonales.Controls.Add(this.label17);
            this.gbDatosPersonales.Controls.Add(this.button1);
            this.gbDatosPersonales.Controls.Add(this.label15);
            this.gbDatosPersonales.Controls.Add(this.txtCCC);
            this.gbDatosPersonales.Controls.Add(this.txtForder);
            this.gbDatosPersonales.Controls.Add(this.label1);
            this.gbDatosPersonales.Controls.Add(this.txtNif);
            this.gbDatosPersonales.Controls.Add(this.label2);
            this.gbDatosPersonales.Controls.Add(this.txtEmail);
            this.gbDatosPersonales.Controls.Add(this.label3);
            this.gbDatosPersonales.Controls.Add(this.txtMovil);
            this.gbDatosPersonales.Controls.Add(this.label4);
            this.gbDatosPersonales.Controls.Add(this.label9);
            this.gbDatosPersonales.Controls.Add(this.txtTelefono);
            this.gbDatosPersonales.Controls.Add(this.label8);
            this.gbDatosPersonales.Controls.Add(this.label5);
            this.gbDatosPersonales.Controls.Add(this.label7);
            this.gbDatosPersonales.Controls.Add(this.txtDireccion);
            this.gbDatosPersonales.Controls.Add(this.label6);
            this.gbDatosPersonales.Controls.Add(this.txtPoblacion);
            this.gbDatosPersonales.Controls.Add(this.txtLicencia);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(419, 330);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.Text = "Datos personales";
            // 
            // textEditIban
            // 
            this.textEditIban.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Iban", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textEditIban.Location = new System.Drawing.Point(121, 258);
            this.textEditIban.Name = "textEditIban";
            this.textEditIban.Properties.MaxLength = 30;
            this.textEditIban.Size = new System.Drawing.Size(285, 20);
            this.textEditIban.TabIndex = 21;
            this.textEditIban.EditValueChanged += new System.EventHandler(this.TextEditIbanEditValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(87, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Iban";
            // 
            // gbDatosEconomicos
            // 
            this.gbDatosEconomicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDatosEconomicos.Controls.Add(this.txtKilometros);
            this.gbDatosEconomicos.Controls.Add(this.txtHorasEspera);
            this.gbDatosEconomicos.Controls.Add(this.txtIva);
            this.gbDatosEconomicos.Controls.Add(this.label12);
            this.gbDatosEconomicos.Controls.Add(this.label10);
            this.gbDatosEconomicos.Controls.Add(this.label11);
            this.gbDatosEconomicos.Location = new System.Drawing.Point(12, 348);
            this.gbDatosEconomicos.Name = "gbDatosEconomicos";
            this.gbDatosEconomicos.Size = new System.Drawing.Size(200, 100);
            this.gbDatosEconomicos.TabIndex = 1;
            this.gbDatosEconomicos.Text = "Datos Económicos";
            // 
            // txtKilometros
            // 
            this.txtKilometros.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "EurosKilometros", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtKilometros.Location = new System.Drawing.Point(95, 75);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Properties.DisplayFormat.FormatString = "c2";
            this.txtKilometros.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKilometros.Properties.EditFormat.FormatString = "c2";
            this.txtKilometros.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKilometros.Properties.Mask.EditMask = "c";
            this.txtKilometros.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKilometros.Size = new System.Drawing.Size(61, 20);
            this.txtKilometros.TabIndex = 29;
            this.txtKilometros.EditValueChanged += new System.EventHandler(this.TxtKilometrosEditValueChanged);
            this.txtKilometros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            // 
            // txtHorasEspera
            // 
            this.txtHorasEspera.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "EurosHora", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtHorasEspera.Location = new System.Drawing.Point(95, 50);
            this.txtHorasEspera.Name = "txtHorasEspera";
            this.txtHorasEspera.Properties.DisplayFormat.FormatString = "c2";
            this.txtHorasEspera.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHorasEspera.Properties.EditFormat.FormatString = "c2";
            this.txtHorasEspera.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHorasEspera.Properties.Mask.EditMask = "c";
            this.txtHorasEspera.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHorasEspera.Size = new System.Drawing.Size(61, 20);
            this.txtHorasEspera.TabIndex = 2;
            this.txtHorasEspera.EditValueChanged += new System.EventHandler(this.TxtHorasEsperaEditValueChanged);
            this.txtHorasEspera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            // 
            // txtIva
            // 
            this.txtIva.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "Iva", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtIva.Location = new System.Drawing.Point(95, 24);
            this.txtIva.Name = "txtIva";
            this.txtIva.Properties.DisplayFormat.FormatString = "p2";
            this.txtIva.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtIva.Properties.EditFormat.FormatString = "p2";
            this.txtIva.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtIva.Properties.Mask.EditMask = "p2";
            this.txtIva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIva.Size = new System.Drawing.Size(61, 20);
            this.txtIva.TabIndex = 0;
            this.txtIva.EditValueChanged += new System.EventHandler(this.TxtIvaEditValueChanged);
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl3.Controls.Add(this.numericUpDownUltimaFActura);
            this.groupControl3.Controls.Add(this.numericUpDownBordeTabla);
            this.groupControl3.Controls.Add(this.numericUpDownNivelFondo);
            this.groupControl3.Controls.Add(this.label16);
            this.groupControl3.Controls.Add(this.label13);
            this.groupControl3.Controls.Add(this.label14);
            this.groupControl3.Location = new System.Drawing.Point(219, 349);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(212, 100);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Factura";
            // 
            // numericUpDownUltimaFActura
            // 
            this.numericUpDownUltimaFActura.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "UltimaFactura", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numericUpDownUltimaFActura.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownUltimaFActura.Location = new System.Drawing.Point(124, 78);
            this.numericUpDownUltimaFActura.Name = "numericUpDownUltimaFActura";
            this.numericUpDownUltimaFActura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numericUpDownUltimaFActura.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownUltimaFActura.TabIndex = 3;
            this.numericUpDownUltimaFActura.EditValueChanged += new System.EventHandler(this.NumericUpDownUltimaFActuraEditValueChanged);
            this.numericUpDownUltimaFActura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            // 
            // numericUpDownBordeTabla
            // 
            this.numericUpDownBordeTabla.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "TablaBorde", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numericUpDownBordeTabla.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownBordeTabla.Location = new System.Drawing.Point(124, 52);
            this.numericUpDownBordeTabla.Name = "numericUpDownBordeTabla";
            this.numericUpDownBordeTabla.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numericUpDownBordeTabla.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownBordeTabla.TabIndex = 2;
            this.numericUpDownBordeTabla.EditValueChanged += new System.EventHandler(this.NumericUpDownBordeTablaEditValueChanged);
            this.numericUpDownBordeTabla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            // 
            // numericUpDownNivelFondo
            // 
            this.numericUpDownNivelFondo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsConfiguracion, "NilvelLmFondo", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numericUpDownNivelFondo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownNivelFondo.Location = new System.Drawing.Point(124, 26);
            this.numericUpDownNivelFondo.Name = "numericUpDownNivelFondo";
            this.numericUpDownNivelFondo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numericUpDownNivelFondo.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownNivelFondo.TabIndex = 1;
            this.numericUpDownNivelFondo.EditValueChanged += new System.EventHandler(this.NumericUpDownNivelFondoEditValueChanged);
            this.numericUpDownNivelFondo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalesCalculadoraOnKeyPress);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.bsConfiguracion;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.gbDatosEconomicos);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.btnGuardar);
            this.MinimumSize = new System.Drawing.Size(451, 498);
            this.Name = "Configuracion";
            this.Size = new System.Drawing.Size(451, 501);
            this.Load += new System.EventHandler(this.ConfiguracionLoad);
            ((System.ComponentModel.ISupportInitialize)(this.txtLicencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoblacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosPersonales)).EndInit();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosEconomicos)).EndInit();
            this.gbDatosEconomicos.ResumeLayout(false);
            this.gbDatosEconomicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHorasEspera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUltimaFActura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBordeTabla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelFondo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtForder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.TextEdit txtLicencia;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtPoblacion;
        private DevExpress.XtraEditors.TextEdit txtMovil;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtNif;
        private DevExpress.XtraEditors.TextEdit txtCCC;
        private DevExpress.XtraEditors.GroupControl gbDatosPersonales;
        private DevExpress.XtraEditors.GroupControl gbDatosEconomicos;
        private DevExpress.XtraEditors.TextEdit txtKilometros;
        private DevExpress.XtraEditors.TextEdit txtHorasEspera;
        private DevExpress.XtraEditors.TextEdit txtIva;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SpinEdit numericUpDownUltimaFActura;
        private DevExpress.XtraEditors.SpinEdit numericUpDownBordeTabla;
        private DevExpress.XtraEditors.SpinEdit numericUpDownNivelFondo;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.BindingSource bsConfiguracion;
        private DevExpress.XtraEditors.TextEdit textEditIban;
        private System.Windows.Forms.Label label17;
    }
}