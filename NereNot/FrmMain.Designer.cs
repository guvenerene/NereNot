
namespace NereNot
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotify = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dgwList = new DevExpress.XtraGrid.GridControl();
            this.grdList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmHead = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmNotify = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmNotifiDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmOffer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmNotifyTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgwNotify = new DevExpress.XtraGrid.GridControl();
            this.grdNotify = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmNotifyHead = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmNotifyTime2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnAdd,
            this.btnUpdate,
            this.btnNotify,
            this.barStaticItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsStubGlyphs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbon.OptionsStubGlyphs.UseFont = true;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(907, 132);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Görev Ekle";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Görev Güncelle";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnNotify
            // 
            this.btnNotify.Caption = "Hatırlatmalar";
            this.btnNotify.Id = 3;
            this.btnNotify.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNotify.ImageOptions.SvgImage")));
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotify_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Id = 4;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.barStaticItem1.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotify);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 550);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(907, 24);
            // 
            // dgwList
            // 
            this.dgwList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwList.Location = new System.Drawing.Point(0, 132);
            this.dgwList.MainView = this.grdList;
            this.dgwList.MenuManager = this.ribbon;
            this.dgwList.Name = "dgwList";
            this.dgwList.Size = new System.Drawing.Size(606, 418);
            this.dgwList.TabIndex = 2;
            this.dgwList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdList});
            // 
            // grdList
            // 
            this.grdList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmHead,
            this.clmNotify,
            this.clmNotifiDate,
            this.clmOffer,
            this.clmProject,
            this.clmFile,
            this.clmNotifyTime});
            this.grdList.GridControl = this.dgwList;
            this.grdList.Name = "grdList";
            this.grdList.DoubleClick += new System.EventHandler(this.grdList_DoubleClick);
            // 
            // clmHead
            // 
            this.clmHead.Caption = "Konu Başlığı";
            this.clmHead.FieldName = "msnHead";
            this.clmHead.MinWidth = 23;
            this.clmHead.Name = "clmHead";
            this.clmHead.OptionsColumn.AllowEdit = false;
            this.clmHead.Visible = true;
            this.clmHead.VisibleIndex = 0;
            this.clmHead.Width = 440;
            // 
            // clmNotify
            // 
            this.clmNotify.Caption = "Hatırlatıcı";
            this.clmNotify.FieldName = "msnNotify";
            this.clmNotify.MinWidth = 23;
            this.clmNotify.Name = "clmNotify";
            this.clmNotify.OptionsColumn.AllowEdit = false;
            this.clmNotify.Visible = true;
            this.clmNotify.VisibleIndex = 2;
            this.clmNotify.Width = 37;
            // 
            // clmNotifiDate
            // 
            this.clmNotifiDate.Caption = "Hatırlatıcı Tarih";
            this.clmNotifiDate.FieldName = "msnNotifyDate";
            this.clmNotifiDate.MinWidth = 23;
            this.clmNotifiDate.Name = "clmNotifiDate";
            this.clmNotifiDate.OptionsColumn.AllowEdit = false;
            this.clmNotifiDate.Visible = true;
            this.clmNotifiDate.VisibleIndex = 3;
            this.clmNotifiDate.Width = 56;
            // 
            // clmOffer
            // 
            this.clmOffer.Caption = "Teklif";
            this.clmOffer.FieldName = "msnOffer";
            this.clmOffer.MinWidth = 23;
            this.clmOffer.Name = "clmOffer";
            this.clmOffer.OptionsColumn.AllowEdit = false;
            this.clmOffer.Visible = true;
            this.clmOffer.VisibleIndex = 5;
            this.clmOffer.Width = 27;
            // 
            // clmProject
            // 
            this.clmProject.Caption = "Proje";
            this.clmProject.FieldName = "msnProject";
            this.clmProject.MinWidth = 23;
            this.clmProject.Name = "clmProject";
            this.clmProject.OptionsColumn.AllowEdit = false;
            this.clmProject.Visible = true;
            this.clmProject.VisibleIndex = 6;
            this.clmProject.Width = 36;
            // 
            // clmFile
            // 
            this.clmFile.Caption = "Doküman";
            this.clmFile.FieldName = "msnFileIsOn";
            this.clmFile.MinWidth = 23;
            this.clmFile.Name = "clmFile";
            this.clmFile.OptionsColumn.AllowEdit = false;
            this.clmFile.Visible = true;
            this.clmFile.VisibleIndex = 1;
            this.clmFile.Width = 37;
            // 
            // clmNotifyTime
            // 
            this.clmNotifyTime.Caption = "Saati";
            this.clmNotifyTime.FieldName = "msnNotifyTime";
            this.clmNotifyTime.MinWidth = 23;
            this.clmNotifyTime.Name = "clmNotifyTime";
            this.clmNotifyTime.Visible = true;
            this.clmNotifyTime.VisibleIndex = 4;
            this.clmNotifyTime.Width = 44;
            // 
            // dgwNotify
            // 
            this.dgwNotify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwNotify.Location = new System.Drawing.Point(605, 132);
            this.dgwNotify.MainView = this.grdNotify;
            this.dgwNotify.MenuManager = this.ribbon;
            this.dgwNotify.Name = "dgwNotify";
            this.dgwNotify.Size = new System.Drawing.Size(302, 418);
            this.dgwNotify.TabIndex = 5;
            this.dgwNotify.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdNotify});
            // 
            // grdNotify
            // 
            this.grdNotify.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmNotifyHead,
            this.clmNotifyTime2});
            this.grdNotify.GridControl = this.dgwNotify;
            this.grdNotify.Name = "grdNotify";
            this.grdNotify.DoubleClick += new System.EventHandler(this.grdNotify_DoubleClick);
            // 
            // clmNotifyHead
            // 
            this.clmNotifyHead.Caption = "Konu Başlığı";
            this.clmNotifyHead.FieldName = "msnHead";
            this.clmNotifyHead.MinWidth = 23;
            this.clmNotifyHead.Name = "clmNotifyHead";
            this.clmNotifyHead.OptionsColumn.AllowEdit = false;
            this.clmNotifyHead.Visible = true;
            this.clmNotifyHead.VisibleIndex = 0;
            this.clmNotifyHead.Width = 250;
            // 
            // clmNotifyTime2
            // 
            this.clmNotifyTime2.Caption = "Saat";
            this.clmNotifyTime2.FieldName = "msnNotifyTime";
            this.clmNotifyTime2.MinWidth = 23;
            this.clmNotifyTime2.Name = "clmNotifyTime2";
            this.clmNotifyTime2.OptionsColumn.AllowEdit = false;
            this.clmNotifyTime2.Visible = true;
            this.clmNotifyTime2.VisibleIndex = 1;
            this.clmNotifyTime2.Width = 73;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 574);
            this.Controls.Add(this.dgwNotify);
            this.Controls.Add(this.dgwList);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Nere Notify";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraGrid.GridControl dgwList;
        private DevExpress.XtraGrid.Views.Grid.GridView grdList;
        private DevExpress.XtraGrid.Columns.GridColumn clmHead;
        private DevExpress.XtraGrid.Columns.GridColumn clmNotify;
        private DevExpress.XtraGrid.Columns.GridColumn clmNotifiDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmOffer;
        private DevExpress.XtraGrid.Columns.GridColumn clmProject;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnNotify;
        private DevExpress.XtraGrid.Columns.GridColumn clmFile;
        private DevExpress.XtraGrid.GridControl dgwNotify;
        private DevExpress.XtraGrid.Views.Grid.GridView grdNotify;
        private DevExpress.XtraGrid.Columns.GridColumn clmNotifyHead;
        private DevExpress.XtraGrid.Columns.GridColumn clmNotifyTime2;
        private DevExpress.XtraGrid.Columns.GridColumn clmNotifyTime;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}