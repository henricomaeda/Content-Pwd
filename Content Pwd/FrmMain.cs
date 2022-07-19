using System;
using System.Windows.Forms;

namespace Content_Pwd
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Classes.Database.Load();
            PicLogo.Select();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Classes.Data.selected_id = -1;

            PicLogo.Select();
            FrmCreate frmCreate = new FrmCreate();
            frmCreate.ShowDialog();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            PicLogo.Select();
            FrmRead frmRead = new FrmRead();
            frmRead.ShowDialog();
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
