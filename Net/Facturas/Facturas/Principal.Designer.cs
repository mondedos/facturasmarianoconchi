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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            DevExpress.Utils.Animation.Transition transition2 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.SlideFadeTransition slideFadeTransition2 = new DevExpress.Utils.Animation.SlideFadeTransition();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemNuevaFactura = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGuardarFactura = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCargarCliente = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageArchivo = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupFactura = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupCliente = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageImpresion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageConfiguracion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControlContenido = new DevExpress.XtraEditors.PanelControl();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItemNuevaFactura,
            this.barButtonItem2,
            this.barButtonItemGuardarFactura,
            this.barButtonItemCargarCliente,
            this.barButtonItemGuardar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageArchivo,
            this.ribbonPageImpresion,
            this.ribbonPageConfiguracion});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(910, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.ribbon_SelectedPageChanging);
            this.ribbon.SelectedPageChanged += new System.EventHandler(this.ribbon_SelectedPageChanged);
            // 
            // barButtonItemNuevaFactura
            // 
            this.barButtonItemNuevaFactura.Caption = "Nueva";
            this.barButtonItemNuevaFactura.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItemNuevaFactura.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemNuevaFactura.Glyph")));
            this.barButtonItemNuevaFactura.Id = 1;
            this.barButtonItemNuevaFactura.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemNuevaFactura.LargeGlyph")));
            this.barButtonItemNuevaFactura.Name = "barButtonItemNuevaFactura";
            this.barButtonItemNuevaFactura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNuevaFactura_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Cargar";
            this.barButtonItem2.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem2.Glyph = global::Facturas.Properties.Resources._1412779741_Download;
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = global::Facturas.Properties.Resources._1412779737_Download;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItemGuardarFactura
            // 
            this.barButtonItemGuardarFactura.Caption = "Guardar";
            this.barButtonItemGuardarFactura.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItemGuardarFactura.Glyph = global::Facturas.Properties.Resources._1412779930_Hard_Disk;
            this.barButtonItemGuardarFactura.Id = 3;
            this.barButtonItemGuardarFactura.LargeGlyph = global::Facturas.Properties.Resources._1412779928_Hard_Disk;
            this.barButtonItemGuardarFactura.Name = "barButtonItemGuardarFactura";
            this.barButtonItemGuardarFactura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItemCargarCliente
            // 
            this.barButtonItemCargarCliente.Caption = "Cargar Datos";
            this.barButtonItemCargarCliente.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItemCargarCliente.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemCargarCliente.Glyph")));
            this.barButtonItemCargarCliente.Id = 4;
            this.barButtonItemCargarCliente.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemCargarCliente.LargeGlyph")));
            this.barButtonItemCargarCliente.Name = "barButtonItemCargarCliente";
            this.barButtonItemCargarCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCargarCliente_ItemClick);
            // 
            // barButtonItemGuardar
            // 
            this.barButtonItemGuardar.Caption = "Guardar Datos";
            this.barButtonItemGuardar.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItemGuardar.Glyph = global::Facturas.Properties.Resources._1412779853_Flash_Disk;
            this.barButtonItemGuardar.Id = 5;
            this.barButtonItemGuardar.LargeGlyph = global::Facturas.Properties.Resources._1412779850_Flash_Disk;
            this.barButtonItemGuardar.Name = "barButtonItemGuardar";
            this.barButtonItemGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGuardar_ItemClick);
            // 
            // ribbonPageArchivo
            // 
            this.ribbonPageArchivo.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupFactura,
            this.ribbonPageGroupCliente});
            this.ribbonPageArchivo.Name = "ribbonPageArchivo";
            this.ribbonPageArchivo.Text = "Archivo";
            // 
            // ribbonPageGroupFactura
            // 
            this.ribbonPageGroupFactura.ItemLinks.Add(this.barButtonItemNuevaFactura);
            this.ribbonPageGroupFactura.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroupFactura.ItemLinks.Add(this.barButtonItemGuardarFactura);
            this.ribbonPageGroupFactura.Name = "ribbonPageGroupFactura";
            this.ribbonPageGroupFactura.ShowCaptionButton = false;
            this.ribbonPageGroupFactura.Text = "Factura";
            // 
            // ribbonPageGroupCliente
            // 
            this.ribbonPageGroupCliente.ItemLinks.Add(this.barButtonItemCargarCliente);
            this.ribbonPageGroupCliente.ItemLinks.Add(this.barButtonItemGuardar);
            this.ribbonPageGroupCliente.Name = "ribbonPageGroupCliente";
            this.ribbonPageGroupCliente.Text = "Cliente";
            // 
            // ribbonPageImpresion
            // 
            this.ribbonPageImpresion.Name = "ribbonPageImpresion";
            this.ribbonPageImpresion.Text = "Imprimir Previsualización";
            // 
            // ribbonPageConfiguracion
            // 
            this.ribbonPageConfiguracion.Name = "ribbonPageConfiguracion";
            this.ribbonPageConfiguracion.Text = "Configuración";
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
            this.panelControlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlContenido.Location = new System.Drawing.Point(0, 144);
            this.panelControlContenido.Name = "panelControlContenido";
            this.panelControlContenido.Size = new System.Drawing.Size(910, 544);
            this.panelControlContenido.TabIndex = 0;
            // 
            // transitionManager1
            // 
            this.transitionManager1.FrameCount = 500;
            this.transitionManager1.FrameInterval = 5000;
            transition2.Control = null;
            transition2.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.True;
            slideFadeTransition2.Parameters.Background = System.Drawing.Color.Empty;
            slideFadeTransition2.Parameters.FramesCount = null;
            transition2.TransitionType = slideFadeTransition2;
            this.transitionManager1.Transitions.Add(transition2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageArchivo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupFactura;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl panelControlContenido;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNuevaFactura;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGuardarFactura;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCargarCliente;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGuardar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCliente;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageImpresion;
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageConfiguracion;
    }
}