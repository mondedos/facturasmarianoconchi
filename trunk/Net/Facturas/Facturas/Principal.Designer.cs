namespace Facturas
{
    partial class Principal
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
            System.Windows.Forms.Label cifLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControlContenido = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.nombreTextBox = new DevExpress.XtraEditors.TextEdit();
            this.bsFactura = new System.Windows.Forms.BindingSource(this.components);
            this.telefonoTextBox = new DevExpress.XtraEditors.TextEdit();
            this.cifTextBox = new DevExpress.XtraEditors.TextEdit();
            this.ciudadTextBox = new DevExpress.XtraEditors.TextEdit();
            this.codigoPostalTextBox = new DevExpress.XtraEditors.TextEdit();
            this.numeroTextBox = new DevExpress.XtraEditors.SpinEdit();
            this.direccionTextBox = new DevExpress.XtraEditors.MemoEdit();
            this.tbFecha = new DevExpress.XtraEditors.DateEdit();
            this.bsLineas = new System.Windows.Forms.BindingSource(this.components);
            this.textEditUnidadOrganica = new DevExpress.XtraEditors.TextEdit();
            this.textEditUnidadTramitadora = new DevExpress.XtraEditors.TextEdit();
            this.groupControlLineas = new DevExpress.XtraEditors.GroupControl();
            cifLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlContenido)).BeginInit();
            this.panelControlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cifTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPostalTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUnidadOrganica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUnidadTramitadora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLineas)).BeginInit();
            this.SuspendLayout();
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
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(9, 27);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(48, 13);
            numeroLabel.TabIndex = 23;
            numeroLabel.Text = "Numero:";
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
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(9, 79);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(48, 13);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "Nombre:";
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
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(910, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 688);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(910, 31);
            // 
            // panelControlContenido
            // 
            this.panelControlContenido.Controls.Add(this.groupControlLineas);
            this.panelControlContenido.Controls.Add(this.groupBox1);
            this.panelControlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlContenido.Location = new System.Drawing.Point(0, 144);
            this.panelControlContenido.Name = "panelControlContenido";
            this.panelControlContenido.Size = new System.Drawing.Size(910, 544);
            this.panelControlContenido.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.textEditUnidadTramitadora);
            this.groupBox1.Controls.Add(this.textEditUnidadOrganica);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nombreTextBox.Location = new System.Drawing.Point(90, 76);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(776, 20);
            this.nombreTextBox.TabIndex = 2;
            this.nombreTextBox.EditValueChanged += new System.EventHandler(this.nombreTextBox_EditValueChanged);
            // 
            // bsFactura
            // 
            this.bsFactura.DataSource = typeof(Facturas.BizzRules.Factura);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Telefono", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.telefonoTextBox.EditValue = "954120606";
            this.telefonoTextBox.Location = new System.Drawing.Point(90, 261);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(66, 20);
            this.telefonoTextBox.TabIndex = 7;
            this.telefonoTextBox.EditValueChanged += new System.EventHandler(this.telefonoTextBox_EditValueChanged);
            // 
            // cifTextBox
            // 
            this.cifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Cif", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cifTextBox.EditValue = "28806983N";
            this.cifTextBox.Location = new System.Drawing.Point(90, 102);
            this.cifTextBox.Name = "cifTextBox";
            this.cifTextBox.Size = new System.Drawing.Size(66, 20);
            this.cifTextBox.TabIndex = 3;
            this.cifTextBox.EditValueChanged += new System.EventHandler(this.cifTextBox_EditValueChanged);
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Ciudad", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.ciudadTextBox.Location = new System.Drawing.Point(90, 209);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(776, 20);
            this.ciudadTextBox.TabIndex = 5;
            this.ciudadTextBox.EditValueChanged += new System.EventHandler(this.ciudadTextBox_EditValueChanged);
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "CodigoPostal", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.codigoPostalTextBox.EditValue = "41089";
            this.codigoPostalTextBox.Location = new System.Drawing.Point(90, 235);
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(66, 20);
            this.codigoPostalTextBox.TabIndex = 6;
            this.codigoPostalTextBox.EditValueChanged += new System.EventHandler(this.codigoPostalTextBox_EditValueChanged);
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Numero", true, System.Windows.Forms.DataSourceUpdateMode.Never));
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
            this.numeroTextBox.EditValueChanged += new System.EventHandler(this.numeroTextBox_EditValueChanged);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Direccion", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.direccionTextBox.Location = new System.Drawing.Point(90, 128);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(776, 75);
            this.direccionTextBox.TabIndex = 4;
            this.direccionTextBox.EditValueChanged += new System.EventHandler(this.direccionTextBox_EditValueChanged);
            // 
            // tbFecha
            // 
            this.tbFecha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Fecha", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.tbFecha.EditValue = null;
            this.tbFecha.Location = new System.Drawing.Point(90, 50);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbFecha.Properties.Mask.EditMask = "";
            this.tbFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.tbFecha.Size = new System.Drawing.Size(66, 20);
            this.tbFecha.TabIndex = 1;
            this.tbFecha.EditValueChanged += new System.EventHandler(this.tbFecha_EditValueChanged);
            // 
            // bsLineas
            // 
            this.bsLineas.DataSource = typeof(Facturas.BizzRules.LineaFactura);
            this.bsLineas.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bsLineas_AddingNew);
            // 
            // textEditUnidadOrganica
            // 
            this.textEditUnidadOrganica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditUnidadOrganica.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "UnidadOrganica", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textEditUnidadOrganica.Location = new System.Drawing.Point(399, 238);
            this.textEditUnidadOrganica.MenuManager = this.ribbon;
            this.textEditUnidadOrganica.Name = "textEditUnidadOrganica";
            this.textEditUnidadOrganica.Size = new System.Drawing.Size(467, 20);
            this.textEditUnidadOrganica.TabIndex = 26;
            this.textEditUnidadOrganica.EditValueChanged += new System.EventHandler(this.textEditUnidadOrganica_EditValueChanged);
            // 
            // textEditUnidadTramitadora
            // 
            this.textEditUnidadTramitadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditUnidadTramitadora.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "UnidadTramitadora", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textEditUnidadTramitadora.Location = new System.Drawing.Point(399, 264);
            this.textEditUnidadTramitadora.MenuManager = this.ribbon;
            this.textEditUnidadTramitadora.Name = "textEditUnidadTramitadora";
            this.textEditUnidadTramitadora.Size = new System.Drawing.Size(467, 20);
            this.textEditUnidadTramitadora.TabIndex = 27;
            this.textEditUnidadTramitadora.EditValueChanged += new System.EventHandler(this.textEditUnidadTramitadora_EditValueChanged);
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(303, 242);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 13);
            label1.TabIndex = 28;
            label1.Text = "Unidad Orgánica:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(288, 267);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 13);
            label2.TabIndex = 29;
            label2.Text = "Unidad Tramitadora:";
            // 
            // groupControlLineas
            // 
            this.groupControlLineas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlLineas.Location = new System.Drawing.Point(12, 300);
            this.groupControlLineas.Name = "groupControlLineas";
            this.groupControlLineas.Size = new System.Drawing.Size(886, 238);
            this.groupControlLineas.TabIndex = 2;
            this.groupControlLineas.Text = "Líneas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 719);
            this.Controls.Add(this.panelControlContenido);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Principal";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlContenido)).EndInit();
            this.panelControlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cifTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPostalTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUnidadOrganica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUnidadTramitadora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl panelControlContenido;
        private System.Windows.Forms.BindingSource bsFactura;
        private System.Windows.Forms.BindingSource bsLineas;
        private DevExpress.XtraEditors.GroupControl groupBox1;
        private DevExpress.XtraEditors.TextEdit nombreTextBox;
        private DevExpress.XtraEditors.TextEdit telefonoTextBox;
        private DevExpress.XtraEditors.TextEdit cifTextBox;
        private DevExpress.XtraEditors.TextEdit ciudadTextBox;
        private DevExpress.XtraEditors.TextEdit codigoPostalTextBox;
        private DevExpress.XtraEditors.SpinEdit numeroTextBox;
        private DevExpress.XtraEditors.MemoEdit direccionTextBox;
        private DevExpress.XtraEditors.DateEdit tbFecha;
        private DevExpress.XtraEditors.TextEdit textEditUnidadTramitadora;
        private DevExpress.XtraEditors.TextEdit textEditUnidadOrganica;
        private DevExpress.XtraEditors.GroupControl groupControlLineas;
    }
}