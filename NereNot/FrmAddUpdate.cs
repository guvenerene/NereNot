using NereNot._TOOLS;
using NereNot.Entity;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NereNot
{
    public partial class FrmAddUpdate : DevExpress.XtraEditors.XtraForm
    {
        public FrmAddUpdate()
        {
            InitializeComponent();
        }
        Context dBconnection = new Context();
        Mission useMission = new Mission();

        string path = @"\\192.168.1.108\NereFile\";
        //string path = @"C:\NereFile\";



        public Guid msnRef { get; set; }

        bool SaveControl()
        {
            StringBuilder stb = new StringBuilder();

            if (txtHead.Text.Length == 0 || txtHead.EditValue == null)
                stb.AppendLine("Başlık Alanı Boş Geçilemez.\n");

            if (memContent.Text.Length == 0 || memContent.EditValue == null)
                stb.AppendLine("İçerik Alanı Boş Geçilemez!\n");

            if (tglNotify.IsOn == true && (dtNotify.Text.Length == 0 || dtNotify.EditValue == null))
                stb.AppendLine("Hatırlatıcı Var İse Hatırlatıcı Tarihi Boş Geçilemez!");



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
        void FillData(Guid Ref)
        {
            useMission = dBconnection.Mission.FirstOrDefault(f => f.msnRef == Ref);
            if (useMission == null)
                useMission = new Mission();

            txtHead.EditValue = useMission.msnHead;
            memContent.EditValue = useMission.msnContent;
            tglNotify.IsOn = useMission.msnNotify;
            if (useMission.msnNotify == true)
                dtNotify.EditValue = useMission.msnNotifyDate;
            chkOffer.EditValue = useMission.msnOffer;
            chkProject.EditValue = useMission.msnProject;
            txtNotifyTime.EditValue = useMission.msnNotifyTime;

        }

        private void FrmNew_Load(object sender, EventArgs e)
        {
            dtNotify.EditValue = "";
            dtNotify.Enabled = false;
            txtNotifyTime.Enabled = false;

            if (msnRef != Guid.Empty)
            {
                //useMission.msnRef = msnRef;
                FillData(msnRef);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (SaveControl())
            {
                using (DbContextTransaction transaction = dBconnection.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        if (txtHead.Text != "" || txtHead.Text.Length > 0)
                            useMission.msnHead = txtHead.Text;
                        if (memContent.Text != "" || memContent.Text.Length > 0)
                            useMission.msnContent = memContent.Text;

                        useMission.msnNotify = tglNotify.IsOn;
                        useMission.msnOffer = chkOffer.Checked;
                        useMission.msnProject = chkProject.Checked;

                        if (tglNotify.IsOn == true)
                        {
                            useMission.msnNotifyDate = Convert.ToDateTime(dtNotify.Text);
                            useMission.msnNotifyTime = DateTime.Parse(txtNotifyTime.Text).TimeOfDay.ToString();
                        }
                        else
                        {
                            useMission.msnNotifyDate = Convert.ToDateTime("2000-01-01");
                            useMission.msnNotifyTime = Convert.ToString("00:00:00");
                        }

                        try
                        {
                            if (Directory.GetFiles(path + useMission.msnRef.ToString()).Length > 0)
                                useMission.msnFileIsOn = true;
                        }
                        catch (Exception)
                        {
                            useMission.msnFileIsOn = false;
                        }




                        //guid daha öceden var mı kontrol edilecek
                        if (dBconnection.Mission.Count(c => c.msnRef == useMission.msnRef) == 0)
                            dBconnection.Mission.Add(useMission);


                        dBconnection.SaveChanges();
                        transaction.Commit();
                        XtraMessageBox.Show("Kayıt başarılı bir şekilde gerçekleşti.", "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        this.Refresh();
                    }
                    catch (Exception ex)
                    {
                        var a = ex.GetType();
                        XtraMessageBox.Show("Bir hata meydana geldi.\n\rHata: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                    }
                }
            }

        }

        private void tglNotify_Toggled(object sender, EventArgs e)
        {
            if (tglNotify.IsOn == false)
            {
                dtNotify.EditValue = null;
                dtNotify.Enabled = false;
                txtNotifyTime.Enabled = false;
            }
            if (tglNotify.IsOn == true)
            {
                dtNotify.EditValue = DateTime.Today.ToShortDateString();
                dtNotify.Enabled = true;
                txtNotifyTime.Enabled = true;
            }
        }

        private void btnFileAdd_Click(object sender, EventArgs e)
        {
            string sourceFile = "", sourceFileName = "", targetFolder = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Doküman Seçiniz...";
                openFileDialog.FileName = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    sourceFileName = openFileDialog.SafeFileName.ToString();
                    sourceFile = openFileDialog.FileName.ToString();
                }
                else
                {
                    XtraMessageBox.Show("Dosya Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Directory.CreateDirectory(path + useMission.msnRef.ToString());
            targetFolder = path + useMission.msnRef.ToString();


            if (targetFolder != "" && sourceFile != "")
            {
                if (File.Exists(targetFolder + "\\" + sourceFileName))
                {
                    XtraMessageBox.Show("Belirtilen klasörde " + sourceFileName + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    File.Copy(sourceFile, targetFolder + "\\" + sourceFileName);
                    XtraMessageBox.Show("Doküman Kayıt Edildi");
                }
            }
        }

        private void btnFileFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dosyalar = Directory.GetFiles(path + useMission.msnRef.ToString());
                System.Diagnostics.Process.Start("explorer.exe", path + useMission.msnRef.ToString());
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Klasör Bulunamadı");
            }


        }
    }
}