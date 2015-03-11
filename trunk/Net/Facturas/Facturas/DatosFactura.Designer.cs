namespace Facturas
{
    partial class DatosFactura
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cifLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaLabel;
            this.bsLineas = new System.Windows.Forms.BindingSource(this.components);
            this.bsFactura = new System.Windows.Forms.BindingSource(this.components);
            this.groupControlLineas = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEditConcepto = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colKilometros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHorasEspera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKilometrosEuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHorasEuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.textEditUnidadTramitadora = new DevExpress.XtraEditors.TextEdit();
            this.textEditUnidadOrganica = new DevExpress.XtraEditors.TextEdit();
            this.nombreTextBox = new DevExpress.XtraEditors.TextEdit();
            this.telefonoTextBox = new DevExpress.XtraEditors.TextEdit();
            this.cifTextBox = new DevExpress.XtraEditors.TextEdit();
            this.ciudadTextBox = new DevExpress.XtraEditors.TextEdit();
            this.codigoPostalTextBox = new DevExpress.XtraEditors.TextEdit();
            this.numeroTextBox = new DevExpress.XtraEditors.SpinEdit();
            this.direccionTextBox = new DevExpress.XtraEditors.MemoEdit();
            this.tbFecha = new DevExpress.XtraEditors.DateEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cifLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLineas)).BeginInit();
            this.groupControlLineas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUnidadTramitadora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUnidadOrganica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cifTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPostalTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
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
            // bsLineas
            // 
            this.bsLineas.DataSource = typeof(Facturas.BizzRules.LineaFactura);
            this.bsLineas.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bsLineas_AddingNew);
            // 
            // bsFactura
            // 
            this.bsFactura.DataSource = typeof(Facturas.BizzRules.Factura);
            this.bsFactura.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bsFactura_AddingNew);
            // 
            // groupControlLineas
            // 
            this.groupControlLineas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlLineas.Controls.Add(this.gridControl1);
            this.groupControlLineas.Location = new System.Drawing.Point(12, 300);
            this.groupControlLineas.Name = "groupControlLineas";
            this.groupControlLineas.Size = new System.Drawing.Size(886, 238);
            this.groupControlLineas.TabIndex = 3;
            this.groupControlLineas.Text = "Líneas";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.bsLineas;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEditConcepto,
            this.repositoryItemCalcEdit1});
            this.gridControl1.Size = new System.Drawing.Size(882, 215);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colConcepto,
            this.colKilometros,
            this.colHorasEspera,
            this.colCantidad,
            this.colKilometrosEuros,
            this.colHorasEuros});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKilometrosEuros, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colConcepto
            // 
            this.colConcepto.ColumnEdit = this.repositoryItemMemoEditConcepto;
            this.colConcepto.DisplayFormat.FormatString = "n2";
            this.colConcepto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colConcepto.FieldName = "Concepto";
            this.colConcepto.GroupFormat.FormatString = "n2";
            this.colConcepto.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.Visible = true;
            this.colConcepto.VisibleIndex = 0;
            this.colConcepto.Width = 789;
            // 
            // repositoryItemMemoEditConcepto
            // 
            this.repositoryItemMemoEditConcepto.Name = "repositoryItemMemoEditConcepto";
            // 
            // colKilometros
            // 
            this.colKilometros.DisplayFormat.FormatString = "n2";
            this.colKilometros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKilometros.FieldName = "Kilometros";
            this.colKilometros.GroupFormat.FormatString = "n2";
            this.colKilometros.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKilometros.Name = "colKilometros";
            this.colKilometros.Visible = true;
            this.colKilometros.VisibleIndex = 2;
            this.colKilometros.Width = 73;
            // 
            // colHorasEspera
            // 
            this.colHorasEspera.DisplayFormat.FormatString = "n2";
            this.colHorasEspera.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHorasEspera.FieldName = "HorasEspera";
            this.colHorasEspera.GroupFormat.FormatString = "n2";
            this.colHorasEspera.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHorasEspera.Name = "colHorasEspera";
            this.colHorasEspera.Visible = true;
            this.colHorasEspera.VisibleIndex = 4;
            this.colHorasEspera.Width = 74;
            // 
            // colCantidad
            // 
            this.colCantidad.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colCantidad.DisplayFormat.FormatString = "c2";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.GroupFormat.FormatString = "c2";
            this.colCantidad.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 5;
            this.colCantidad.Width = 195;
            // 
            // colKilometrosEuros
            // 
            this.colKilometrosEuros.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colKilometrosEuros.DisplayFormat.FormatString = "c2";
            this.colKilometrosEuros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKilometrosEuros.FieldName = "KilometrosEuros";
            this.colKilometrosEuros.GroupFormat.FormatString = "c2";
            this.colKilometrosEuros.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKilometrosEuros.Name = "colKilometrosEuros";
            this.colKilometrosEuros.Visible = true;
            this.colKilometrosEuros.VisibleIndex = 1;
            this.colKilometrosEuros.Width = 110;
            // 
            // colHorasEuros
            // 
            this.colHorasEuros.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colHorasEuros.DisplayFormat.FormatString = "c2";
            this.colHorasEuros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHorasEuros.FieldName = "HorasEuros";
            this.colHorasEuros.GroupFormat.FormatString = "c2";
            this.colHorasEuros.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHorasEuros.Name = "colHorasEuros";
            this.colHorasEuros.Visible = true;
            this.colHorasEuros.VisibleIndex = 3;
            this.colHorasEuros.Width = 71;
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
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // textEditUnidadTramitadora
            // 
            this.textEditUnidadTramitadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditUnidadTramitadora.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "UnidadTramitadora", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textEditUnidadTramitadora.Location = new System.Drawing.Point(399, 264);
            this.textEditUnidadTramitadora.Name = "textEditUnidadTramitadora";
            this.textEditUnidadTramitadora.Size = new System.Drawing.Size(467, 20);
            this.textEditUnidadTramitadora.TabIndex = 9;
            this.textEditUnidadTramitadora.EditValueChanged += new System.EventHandler(this.textEditUnidadTramitadora_EditValueChanged);
            // 
            // textEditUnidadOrganica
            // 
            this.textEditUnidadOrganica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditUnidadOrganica.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "UnidadOrganica", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textEditUnidadOrganica.Location = new System.Drawing.Point(399, 238);
            this.textEditUnidadOrganica.Name = "textEditUnidadOrganica";
            this.textEditUnidadOrganica.Size = new System.Drawing.Size(467, 20);
            this.textEditUnidadOrganica.TabIndex = 8;
            this.textEditUnidadOrganica.EditValueChanged += new System.EventHandler(this.textEditUnidadOrganica_EditValueChanged);
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
            // telefonoTextBox
            // 
            this.telefonoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Telefono", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.telefonoTextBox.EditValue = "954120606";
            this.telefonoTextBox.Location = new System.Drawing.Point(90, 261);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(84, 20);
            this.telefonoTextBox.TabIndex = 7;
            this.telefonoTextBox.EditValueChanged += new System.EventHandler(this.telefonoTextBox_EditValueChanged);
            // 
            // cifTextBox
            // 
            this.cifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsFactura, "Cif", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cifTextBox.EditValue = "28806983N";
            this.cifTextBox.Location = new System.Drawing.Point(90, 102);
            this.cifTextBox.Name = "cifTextBox";
            this.cifTextBox.Size = new System.Drawing.Size(84, 20);
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
            this.codigoPostalTextBox.Size = new System.Drawing.Size(84, 20);
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
            this.numeroTextBox.Size = new System.Drawing.Size(84, 20);
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
            this.tbFecha.EditValue = new System.DateTime(2015, 3, 5, 17, 1, 16, 240);
            this.tbFecha.Location = new System.Drawing.Point(90, 50);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tbFecha.Properties.Mask.EditMask = "";
            this.tbFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.tbFecha.Size = new System.Drawing.Size(84, 20);
            this.tbFecha.TabIndex = 1;
            this.tbFecha.EditValueChanged += new System.EventHandler(this.tbFecha_EditValueChanged);
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.DisplayFormat.FormatString = "c2";
            this.repositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit1.EditFormat.FormatString = "c2";
            this.repositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCalcEdit1.Mask.EditMask = "c2";
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // DatosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControlLineas);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatosFactura";
            this.Size = new System.Drawing.Size(910, 544);
            ((System.ComponentModel.ISupportInitialize)(this.bsLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLineas)).EndInit();
            this.groupControlLineas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEditConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUnidadTramitadora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUnidadOrganica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cifTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPostalTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsLineas;
        private System.Windows.Forms.BindingSource bsFactura;
        private DevExpress.XtraEditors.GroupControl groupControlLineas;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colConcepto;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEditConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colKilometros;
        private DevExpress.XtraGrid.Columns.GridColumn colHorasEspera;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colKilometrosEuros;
        private DevExpress.XtraGrid.Columns.GridColumn colHorasEuros;
        private DevExpress.XtraEditors.GroupControl groupBox1;
        private DevExpress.XtraEditors.TextEdit textEditUnidadTramitadora;
        private DevExpress.XtraEditors.TextEdit textEditUnidadOrganica;
        private DevExpress.XtraEditors.TextEdit nombreTextBox;
        private DevExpress.XtraEditors.TextEdit telefonoTextBox;
        private DevExpress.XtraEditors.TextEdit cifTextBox;
        private DevExpress.XtraEditors.TextEdit ciudadTextBox;
        private DevExpress.XtraEditors.TextEdit codigoPostalTextBox;
        private DevExpress.XtraEditors.SpinEdit numeroTextBox;
        private DevExpress.XtraEditors.MemoEdit direccionTextBox;
        private DevExpress.XtraEditors.DateEdit tbFecha;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
    }
}
