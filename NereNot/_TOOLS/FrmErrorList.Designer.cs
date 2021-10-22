
namespace NereNot._TOOLS
{
    partial class FrmErrorList
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
            this.NereMemoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.NereMemoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // NereMemoEdit1
            // 
            this.NereMemoEdit1.Location = new System.Drawing.Point(0, -1);
            this.NereMemoEdit1.Name = "NereMemoEdit1";
            this.NereMemoEdit1.Properties.ReadOnly = true;
            this.NereMemoEdit1.Size = new System.Drawing.Size(299, 270);
            this.NereMemoEdit1.TabIndex = 2;
            // 
            // FrmErrorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.NereMemoEdit1);
            this.Name = "FrmErrorList";
            this.Text = "FrmErrorList";
            ((System.ComponentModel.ISupportInitialize)(this.NereMemoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.MemoEdit NereMemoEdit1;
    }
}