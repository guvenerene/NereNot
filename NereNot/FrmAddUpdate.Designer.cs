
namespace NereNot
{
    partial class FrmAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdate));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.memContent = new DevExpress.XtraEditors.MemoEdit();
            this.txtHead = new DevExpress.XtraEditors.TextEdit();
            this.dtNotify = new DevExpress.XtraEditors.DateEdit();
            this.tglNotify = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chkOffer = new DevExpress.XtraEditors.CheckEdit();
            this.chkProject = new DevExpress.XtraEditors.CheckEdit();
            this.btnFileAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnFileFolder = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNotifyTime = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotify.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotify.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglNotify.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOffer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotifyTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(762, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 64);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // memContent
            // 
            this.memContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memContent.Location = new System.Drawing.Point(12, 54);
            this.memContent.Name = "memContent";
            this.memContent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memContent.Properties.Appearance.Options.UseFont = true;
            this.memContent.Size = new System.Drawing.Size(865, 385);
            this.memContent.TabIndex = 7;
            // 
            // txtHead
            // 
            this.txtHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHead.Location = new System.Drawing.Point(12, 28);
            this.txtHead.Name = "txtHead";
            this.txtHead.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHead.Properties.Appearance.Options.UseFont = true;
            this.txtHead.Size = new System.Drawing.Size(460, 22);
            this.txtHead.TabIndex = 1;
            // 
            // dtNotify
            // 
            this.dtNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNotify.EditValue = null;
            this.dtNotify.Location = new System.Drawing.Point(698, 26);
            this.dtNotify.Name = "dtNotify";
            this.dtNotify.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtNotify.Properties.Appearance.Options.UseFont = true;
            this.dtNotify.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNotify.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNotify.Size = new System.Drawing.Size(95, 22);
            this.dtNotify.TabIndex = 5;
            // 
            // tglNotify
            // 
            this.tglNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tglNotify.Location = new System.Drawing.Point(596, 26);
            this.tglNotify.Name = "tglNotify";
            this.tglNotify.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tglNotify.Properties.Appearance.Options.UseFont = true;
            this.tglNotify.Properties.OffText = "Kapalı";
            this.tglNotify.Properties.OnText = "Açık";
            this.tglNotify.Size = new System.Drawing.Size(93, 20);
            this.tglNotify.TabIndex = 4;
            this.tglNotify.Toggled += new System.EventHandler(this.tglNotify_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Konu";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(596, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Hatırlatıcı";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(698, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Tarihi";
            // 
            // chkOffer
            // 
            this.chkOffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOffer.Location = new System.Drawing.Point(482, 26);
            this.chkOffer.Name = "chkOffer";
            this.chkOffer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOffer.Properties.Appearance.Options.UseFont = true;
            this.chkOffer.Properties.Caption = "Tekif";
            this.chkOffer.Size = new System.Drawing.Size(51, 20);
            this.chkOffer.TabIndex = 2;
            // 
            // chkProject
            // 
            this.chkProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkProject.Location = new System.Drawing.Point(539, 26);
            this.chkProject.Name = "chkProject";
            this.chkProject.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkProject.Properties.Appearance.Options.UseFont = true;
            this.chkProject.Properties.Caption = "Proje";
            this.chkProject.Size = new System.Drawing.Size(51, 20);
            this.chkProject.TabIndex = 3;
            // 
            // btnFileAdd
            // 
            this.btnFileAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFileAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileAdd.Appearance.Options.UseFont = true;
            this.btnFileAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFileAdd.ImageOptions.Image")));
            this.btnFileAdd.Location = new System.Drawing.Point(12, 445);
            this.btnFileAdd.Name = "btnFileAdd";
            this.btnFileAdd.Size = new System.Drawing.Size(115, 64);
            this.btnFileAdd.TabIndex = 8;
            this.btnFileAdd.Text = "Dosya Ekle";
            this.btnFileAdd.Click += new System.EventHandler(this.btnFileAdd_Click);
            // 
            // btnFileFolder
            // 
            this.btnFileFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFileFolder.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileFolder.Appearance.Options.UseFont = true;
            this.btnFileFolder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFileFolder.ImageOptions.Image")));
            this.btnFileFolder.Location = new System.Drawing.Point(133, 445);
            this.btnFileFolder.Name = "btnFileFolder";
            this.btnFileFolder.Size = new System.Drawing.Size(115, 64);
            this.btnFileFolder.TabIndex = 9;
            this.btnFileFolder.Text = "Dokümanlar";
            this.btnFileFolder.Click += new System.EventHandler(this.btnFileFolder_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(802, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 16);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Saati";
            // 
            // txtNotifyTime
            // 
            this.txtNotifyTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotifyTime.EditValue = new System.DateTime(2021, 2, 25, 0, 0, 0, 0);
            this.txtNotifyTime.Location = new System.Drawing.Point(802, 25);
            this.txtNotifyTime.Name = "txtNotifyTime";
            this.txtNotifyTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotifyTime.Properties.Appearance.Options.UseFont = true;
            this.txtNotifyTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNotifyTime.Size = new System.Drawing.Size(75, 22);
            this.txtNotifyTime.TabIndex = 6;
            // 
            // FrmAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 521);
            this.Controls.Add(this.txtNotifyTime);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnFileFolder);
            this.Controls.Add(this.btnFileAdd);
            this.Controls.Add(this.chkProject);
            this.Controls.Add(this.chkOffer);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tglNotify);
            this.Controls.Add(this.dtNotify);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.memContent);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmAddUpdate";
            this.Text = "Görev";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotify.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotify.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglNotify.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOffer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotifyTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit memContent;
        private DevExpress.XtraEditors.TextEdit txtHead;
        private DevExpress.XtraEditors.DateEdit dtNotify;
        private DevExpress.XtraEditors.ToggleSwitch tglNotify;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chkOffer;
        private DevExpress.XtraEditors.CheckEdit chkProject;
        private DevExpress.XtraEditors.SimpleButton btnFileAdd;
        private DevExpress.XtraEditors.SimpleButton btnFileFolder;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TimeEdit txtNotifyTime;
    }
}