using NereNot._TOOLS;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NereNot
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (grdList.SelectedRowsCount <= 0)
                stb.AppendLine("Görev Seçmeden Bu İşlem Yapılamaz!");



            if (stb.Length > 0)
            {
                FrmErrorList fHata = new FrmErrorList();
                fHata.NereMemoEdit1.Text = stb.ToString();
                fHata.ShowDialog();

                return false;
            }
            else
            {
                return true;
            }
        }

        void reflesh()
        {
            string qList = string.Format(@" SELECT * 
                                            FROM Mission
                                            ");
            dgwList.DataSource = Data.VeriGetirDatable(Program.NotifyConnStr, qList);
            string qNotify = string.Format(@"   SELECT * 
                                                FROM Mission
                                                WHERE msnNotifyDate='{0}'
                                                ORDER BY msnNotifyTime ASC", DateTime.Today.ToString("yyyy.MM.dd"));
            dgwNotify.DataSource = Data.VeriGetirDatable(Program.NotifyConnStr, qNotify);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
            string path = @"C:\NereFile";
            Directory.CreateDirectory(path);
            reflesh();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmAddUpdate fNew = new FrmAddUpdate();
            //fNew.ShowDialog();
            if (fNew.ShowDialog() == DialogResult.OK)
            {
                reflesh();
            }
        }

        private void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SaveControl())
            {
                FrmAddUpdate ofrmAddUpdate = new FrmAddUpdate();
                if (grdList.GetFocusedDataRow() != null)
                {
                    ofrmAddUpdate.msnRef = Guid.Parse(grdList.GetFocusedDataRow()["msnRef"].ToString());
                    this.DialogResult = DialogResult.OK;
                }

                if (ofrmAddUpdate.ShowDialog() == DialogResult.OK)
                {
                    string qList = string.Format(@" SELECT * 
                                                    FROM Mission
                                                    ");
                    dgwList.DataSource = Data.VeriGetirDatable(Program.NotifyConnStr, qList);
                }

            }
        }
        int count = 0;
        private void btnNotify_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (count == 0)
            {
                btnNotify.Caption = "Tüm Görevler";
                count = 1;
                string qList = string.Format(@" SELECT *
                             FROM Mission
                             WHERE msnNotify = 'TRUE'
                             ");
                dgwList.DataSource = Data.VeriGetirDatable(Program.NotifyConnStr, qList);
            }
            else
            {
                btnNotify.Caption = "Hatırlatmalar";
                count = 0;
                reflesh();
            }
        }

        private void dgwList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void grdNotify_DoubleClick(object sender, EventArgs e)
        {
            FrmAddUpdate ofrmAddUpdate = new FrmAddUpdate();
            if (grdList.GetFocusedDataRow() != null)
            {
                ofrmAddUpdate.msnRef = Guid.Parse(grdNotify.GetFocusedDataRow()["msnRef"].ToString());
                this.DialogResult = DialogResult.OK;
            }

            if (ofrmAddUpdate.ShowDialog() == DialogResult.OK)
            {
                reflesh();
            }
        }

        private void grdList_DoubleClick(object sender, EventArgs e)
        {
            if (SaveControl())
            {
                FrmAddUpdate ofrmAddUpdate = new FrmAddUpdate();
                if (grdList.GetFocusedDataRow() != null)
                {
                    ofrmAddUpdate.msnRef = Guid.Parse(grdList.GetFocusedDataRow()["msnRef"].ToString());
                    this.DialogResult = DialogResult.OK;
                }

                if (ofrmAddUpdate.ShowDialog() == DialogResult.OK)
                {
                    reflesh();
                }
            }
        }
    }
}