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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
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
            this.txtCCC = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbDatosEconomicos = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.txtHorasEspera = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownBordeTabla = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownNivelFondo = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbDatosPersonales.SuspendLayout();
            this.gbDatosEconomicos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBordeTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatosPersonales.Controls.Add(this.label15);
            this.gbDatosPersonales.Controls.Add(this.txtForder);
            this.gbDatosPersonales.Controls.Add(this.button1);
            this.gbDatosPersonales.Controls.Add(this.label9);
            this.gbDatosPersonales.Controls.Add(this.label8);
            this.gbDatosPersonales.Controls.Add(this.label7);
            this.gbDatosPersonales.Controls.Add(this.label6);
            this.gbDatosPersonales.Controls.Add(this.label5);
            this.gbDatosPersonales.Controls.Add(this.label4);
            this.gbDatosPersonales.Controls.Add(this.label3);
            this.gbDatosPersonales.Controls.Add(this.label2);
            this.gbDatosPersonales.Controls.Add(this.label1);
            this.gbDatosPersonales.Controls.Add(this.txtCCC);
            this.gbDatosPersonales.Controls.Add(this.txtNif);
            this.gbDatosPersonales.Controls.Add(this.txtEmail);
            this.gbDatosPersonales.Controls.Add(this.txtMovil);
            this.gbDatosPersonales.Controls.Add(this.txtTelefono);
            this.gbDatosPersonales.Controls.Add(this.txtDireccion);
            this.gbDatosPersonales.Controls.Add(this.txtPoblacion);
            this.gbDatosPersonales.Controls.Add(this.txtLicencia);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(392, 294);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos personales";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 256);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Carpeta No Pagada";
            // 
            // txtForder
            // 
            this.txtForder.Location = new System.Drawing.Point(107, 253);
            this.txtForder.Name = "txtForder";
            this.txtForder.ReadOnly = true;
            this.txtForder.Size = new System.Drawing.Size(198, 20);
            this.txtForder.TabIndex = 19;
            this.txtForder.Text = "2106 0950 06 0286145041";
            this.txtForder.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // button1
            // 
            this.button1.Image = global::Facturas.Facturas.explorar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(311, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Explorar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "CCC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "NIF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Móvil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Municipio y CP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Licencia Municipal";
            // 
            // txtCCC
            // 
            this.txtCCC.Location = new System.Drawing.Point(107, 227);
            this.txtCCC.Name = "txtCCC";
            this.txtCCC.Size = new System.Drawing.Size(146, 20);
            this.txtCCC.TabIndex = 8;
            this.txtCCC.Text = "2106 0950 06 0286145041";
            this.txtCCC.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(107, 201);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(77, 20);
            this.txtNif.TabIndex = 7;
            this.txtNif.Text = "28806983N";
            this.txtNif.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(107, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "conchi@montequinto.org";
            this.txtEmail.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // txtMovil
            // 
            this.txtMovil.Location = new System.Drawing.Point(107, 149);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(61, 20);
            this.txtMovil.TabIndex = 5;
            this.txtMovil.Text = "95412606";
            this.txtMovil.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(107, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(61, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.Text = "95412606";
            this.txtTelefono.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(107, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(279, 20);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.Text = "C/ Sector Triángulo, Nº 12 8º A";
            this.txtDireccion.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoblacion.Location = new System.Drawing.Point(107, 71);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(279, 20);
            this.txtPoblacion.TabIndex = 2;
            this.txtPoblacion.Text = "Dos Hermanas, 41089";
            this.txtPoblacion.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(107, 19);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(35, 20);
            this.txtLicencia.TabIndex = 0;
            this.txtLicencia.Text = "1279";
            this.txtLicencia.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(107, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Manuel Prieto Gallego";
            this.txtNombre.TextChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // gbDatosEconomicos
            // 
            this.gbDatosEconomicos.Controls.Add(this.label12);
            this.gbDatosEconomicos.Controls.Add(this.label11);
            this.gbDatosEconomicos.Controls.Add(this.label10);
            this.gbDatosEconomicos.Controls.Add(this.txtKilometros);
            this.gbDatosEconomicos.Controls.Add(this.txtHorasEspera);
            this.gbDatosEconomicos.Controls.Add(this.txtIva);
            this.gbDatosEconomicos.Location = new System.Drawing.Point(12, 312);
            this.gbDatosEconomicos.Name = "gbDatosEconomicos";
            this.gbDatosEconomicos.Size = new System.Drawing.Size(184, 97);
            this.gbDatosEconomicos.TabIndex = 1;
            this.gbDatosEconomicos.TabStop = false;
            this.gbDatosEconomicos.Text = "Datos Económicos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Kilómetro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Hora de espera";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "IVA";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKilometros.Location = new System.Drawing.Point(107, 71);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(63, 20);
            this.txtKilometros.TabIndex = 2;
            this.txtKilometros.TextChanged += new System.EventHandler(this.txtHorasEspera_TextChanged);
            // 
            // txtHorasEspera
            // 
            this.txtHorasEspera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHorasEspera.Location = new System.Drawing.Point(107, 45);
            this.txtHorasEspera.Name = "txtHorasEspera";
            this.txtHorasEspera.Size = new System.Drawing.Size(63, 20);
            this.txtHorasEspera.TabIndex = 1;
            this.txtHorasEspera.TextChanged += new System.EventHandler(this.txtHorasEspera_TextChanged);
            // 
            // txtIva
            // 
            this.txtIva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIva.Location = new System.Drawing.Point(107, 19);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(63, 20);
            this.txtIva.TabIndex = 0;
            this.txtIva.TextChanged += new System.EventHandler(this.txtIva_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = global::Facturas.Facturas.sout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(329, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::Facturas.Facturas.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(248, 418);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 34);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownBordeTabla);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numericUpDownNivelFondo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(202, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // numericUpDownBordeTabla
            // 
            this.numericUpDownBordeTabla.Location = new System.Drawing.Point(127, 41);
            this.numericUpDownBordeTabla.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBordeTabla.Name = "numericUpDownBordeTabla";
            this.numericUpDownBordeTabla.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownBordeTabla.TabIndex = 25;
            this.numericUpDownBordeTabla.ValueChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Borde Tabla";
            // 
            // numericUpDownNivelFondo
            // 
            this.numericUpDownNivelFondo.Location = new System.Drawing.Point(127, 15);
            this.numericUpDownNivelFondo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownNivelFondo.Name = "numericUpDownNivelFondo";
            this.numericUpDownNivelFondo.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownNivelFondo.TabIndex = 23;
            this.numericUpDownNivelFondo.ValueChanged += new System.EventHandler(this.numericUpDownBordeTabla_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "LM Fondo Nivel";
            // 
            // Configuracion
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbDatosEconomicos);
            this.Controls.Add(this.gbDatosPersonales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(367, 456);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuracion_FormClosing);
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbDatosEconomicos.ResumeLayout(false);
            this.gbDatosEconomicos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBordeTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.TextBox txtCCC;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosEconomicos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.TextBox txtHorasEspera;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownNivelFondo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownBordeTabla;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtForder;
        private System.Windows.Forms.Label label15;
    }
}