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

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            var c = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            var r = new Random();
            var p = string.Empty;

            for (int i = 0; i < 20; i++) p += c[r.Next(0, c.Length)];

            TxtPassword.Text = p;
            TxtPassword_GotFocus(sender, e);
            PicLogo.Select();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            PicLogo.Select();
            if (TxtPassword.UseSystemPasswordChar)
            {
                TxtPassword.UseSystemPasswordChar = false;
                BtnView.Text = "Esconder";
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                BtnView.Text = "Revelar";
            }
        }

        private void BtnCreateAndRead_Click(object sender, EventArgs e)
        {
            var t = "Por favor, preencha os campos obrigatórios.\n\nCampos obrigatórios geralmente possuem * em vermelho.";
            var c = string.Empty;
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Exclamation;

            var s = TxtSubject.Text;
            var co = TxtContent.Text;
            var p = TxtPassword.Text;

            PicLogo.Select();
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;
            if (string.IsNullOrWhiteSpace(s)) MessageBox.Show(t, c, b, i);
            else if (string.IsNullOrWhiteSpace(co)) MessageBox.Show(t, c, b, i);
            else if (p.Contains(' '))
            {
                t = "Por favor, apague os espaços inseridos.\n\nO campo de senha não deve conter espaços.";
                MessageBox.Show(t, c, b, i);
            }
            else
            {
                try
                {
                    if (sender == BtnCreate)
                    {

                    }
                    else if (sender == BtnRead)
                    {

                    }
                }
                catch (Exception ex)
                {
                    t = "ERRO: " + ex.Message;
                    i = MessageBoxIcon.Error;
                }
                finally
                {
                    MessageBox.Show(t, c, b, i);
                }
            }
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
