namespace Facturas
{
    partial class UcLinea
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.textEditHoras = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHoras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.SetBoundPropertyName(this.layoutControl1, "");
            this.layoutControl1.Controls.Add(this.textEdit5);
            this.layoutControl1.Controls.Add(this.textEdit4);
            this.layoutControl1.Controls.Add(this.textEdit3);
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.memoEdit1);
            this.layoutControl1.Controls.Add(this.textEditHoras);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(784, 112);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit5
            // 
            this.SetBoundFieldName(this.textEdit5, "Cantidad");
            this.SetBoundPropertyName(this.textEdit5, "EditValue");
            this.textEdit5.EditValue = "";
            this.textEdit5.Location = new System.Drawing.Point(664, 80);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit5.Properties.DisplayFormat.FormatString = "c2";
            this.textEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit5.Properties.EditFormat.FormatString = "c2";
            this.textEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit5.Size = new System.Drawing.Size(108, 20);
            this.textEdit5.StyleController = this.layoutControl1;
            this.textEdit5.TabIndex = 9;
            // 
            // textEdit4
            // 
            this.SetBoundFieldName(this.textEdit4, "HorasEuros");
            this.SetBoundPropertyName(this.textEdit4, "EditValue");
            this.textEdit4.Location = new System.Drawing.Point(200, 80);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit4.Properties.DisplayFormat.FormatString = "c2";
            this.textEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit4.Properties.EditFormat.FormatString = "c2";
            this.textEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit4.Size = new System.Drawing.Size(81, 20);
            this.textEdit4.StyleController = this.layoutControl1;
            this.textEdit4.TabIndex = 8;
            // 
            // textEdit3
            // 
            this.SetBoundFieldName(this.textEdit3, "Kilometros");
            this.SetBoundPropertyName(this.textEdit3, "EditValue");
            this.textEdit3.Location = new System.Drawing.Point(352, 80);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit3.Properties.DisplayFormat.FormatString = "n2";
            this.textEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit3.Properties.EditFormat.FormatString = "n2";
            this.textEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit3.Size = new System.Drawing.Size(109, 20);
            this.textEdit3.StyleController = this.layoutControl1;
            this.textEdit3.TabIndex = 7;
            // 
            // textEdit2
            // 
            this.SetBoundFieldName(this.textEdit2, "KilometrosEuros");
            this.SetBoundPropertyName(this.textEdit2, "EditValue");
            this.textEdit2.Location = new System.Drawing.Point(532, 80);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit2.Properties.DisplayFormat.FormatString = "c2";
            this.textEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit2.Properties.EditFormat.FormatString = "c2";
            this.textEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit2.Size = new System.Drawing.Size(61, 20);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 6;
            // 
            // memoEdit1
            // 
            this.SetBoundFieldName(this.memoEdit1, "Concepto");
            this.SetBoundPropertyName(this.memoEdit1, "EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(79, 12);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(693, 64);
            this.memoEdit1.StyleController = this.layoutControl1;
            this.memoEdit1.TabIndex = 4;
            // 
            // textEditHoras
            // 
            this.SetBoundFieldName(this.textEditHoras, "HorasEspera");
            this.SetBoundPropertyName(this.textEditHoras, "EditValue");
            this.textEditHoras.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEditHoras.Location = new System.Drawing.Point(79, 80);
            this.textEditHoras.Name = "textEditHoras";
            this.textEditHoras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditHoras.Properties.DisplayFormat.FormatString = "n2";
            this.textEditHoras.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditHoras.Properties.EditFormat.FormatString = "n2";
            this.textEditHoras.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditHoras.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEditHoras.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEditHoras.Size = new System.Drawing.Size(50, 20);
            this.textEditHoras.StyleController = this.layoutControl1;
            this.textEditHoras.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(784, 112);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.memoEdit1;
            this.layoutControlItem1.CustomizationFormText = "Concepto";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(764, 68);
            this.layoutControlItem1.Text = "Concepto";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.textEditHoras;
            this.layoutControlItem2.CustomizationFormText = "Horas Espera";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(121, 24);
            this.layoutControlItem2.Text = "Horas Espera";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.textEdit2;
            this.layoutControlItem3.CustomizationFormText = "Precio Km";
            this.layoutControlItem3.Location = new System.Drawing.Point(453, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(132, 24);
            this.layoutControlItem3.Text = "Precio Km";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.textEdit3;
            this.layoutControlItem4.CustomizationFormText = "Kilómetros";
            this.layoutControlItem4.Location = new System.Drawing.Point(273, 68);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(180, 24);
            this.layoutControlItem4.Text = "Kilómetros";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.textEdit4;
            this.layoutControlItem5.CustomizationFormText = "Precio Hora";
            this.layoutControlItem5.Location = new System.Drawing.Point(121, 68);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(152, 24);
            this.layoutControlItem5.Text = "Precio Hora";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.Control = this.textEdit5;
            this.layoutControlItem6.CustomizationFormText = "Cantidad";
            this.layoutControlItem6.Location = new System.Drawing.Point(585, 68);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem6.Text = "Cantidad";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(64, 13);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // UcLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UcLinea";
            this.Size = new System.Drawing.Size(784, 112);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHoras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SpinEdit textEditHoras;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}
