using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Content_Pwd
{
    public partial class FrmCreate : Form
    {
        public FrmCreate()
        {
            InitializeComponent();
        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {

        }

        private void TxtPassword_GotFocus(object sender, EventArgs e)
        {
            if (LblPlaceholder.Visible == true) LblPlaceholder.Visible = false;
            TxtPassword.Select();
        }

        private void TxtPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                TxtPassword.Text = string.Empty;
                LblPlaceholder.Visible = true;
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            PicLogo.Select();
            if (TxtPassword.UseSystemPasswordChar) TxtPassword.UseSystemPasswordChar = false;
            else TxtPassword.UseSystemPasswordChar = true;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

        }

        private void BtnRead_Click(object sender, EventArgs e)
        {

        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
