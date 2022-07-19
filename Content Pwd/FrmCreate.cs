using System;
using System.Drawing;
using System.Linq;
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
            if (Classes.Data.selected_id != -1)
            {
                TxtSubject.Text = Classes.Database.subject[Classes.Data.selected_id];
                TxtContent.Text = Classes.Database.content[Classes.Data.selected_id];

                var p = Classes.Database.password[Classes.Data.selected_id];
                if (!string.IsNullOrWhiteSpace(p))
                {
                    TxtPassword.Text = p;
                    PicLogo.Select();
                }

                BtnUpdate.Enabled = true;
                BtnCreate.Enabled = false;
                BtnCreate.BackColor = Color.Gray;
                this.Text = "Atualizar anotação";
            }
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

            PicLogo.Select();
            TxtPassword.Text = p;
            LblPlaceholder.Visible = false;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            PicLogo.Select();
            if (TxtPassword.UseSystemPasswordChar) TxtPassword.UseSystemPasswordChar = false;
            else TxtPassword.UseSystemPasswordChar = true;
        }

        private void BtnCreateAndUpdate_Click(object sender, EventArgs e)
        {
            var t = "Por favor, preencha os campos obrigatórios.\n\nCampos obrigatórios geralmente possuem * em vermelho.";
            var c = string.Empty;
            var b = MessageBoxButtons.OK;
            var i = MessageBoxIcon.Exclamation;

            var s = TxtSubject.Text;
            var co = TxtContent.Text;
            var p = TxtPassword.Text;
            var v = true;

            PicLogo.Select();
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;
            if (string.IsNullOrWhiteSpace(s)) MessageBox.Show(t, c, b, i);
            else if (string.IsNullOrWhiteSpace(co)) MessageBox.Show(t, c, b, i);
            else if (p.Contains(' '))
            {
                t = "Por favor, apague os espaços inseridos.\n\nO campo de senha não deve conter espaços.";
                MessageBox.Show(t, c, b, i);
            }
            else if (p.Length > 30)
            {
                t = "Por favor, preencha apenas o necessário.\n\nO campo de senha não deve conter mais de 30 caracteres.";
                MessageBox.Show(t, c, b, i);
            }
            else
            {
                try
                {
                    if (sender == BtnCreate)
                    {
                        Classes.Database.Create(s, co, p);

                        t = "O conteúdo foi anotado com sucesso!\n\nAssunto: " + s;
                        i = MessageBoxIcon.Information;
                    }
                    else if (sender == BtnUpdate)
                    {

                        t = "Você tem certeza que deseja atualizar o conteúdo?";
                        b = MessageBoxButtons.YesNo;
                        i = MessageBoxIcon.Question;

                        DialogResult re = MessageBox.Show(t, c, b, i);
                        if (re == DialogResult.Yes)
                        {
                            Classes.Database.Update(s, co, p);

                            t = "O conteúdo foi atualizado com sucesso!\n\nAssunto: " + s;
                            b = MessageBoxButtons.OK;
                            i = MessageBoxIcon.Information;
                        }
                        else v = false;
                    }

                    if (p == string.Empty) t += "\nNenhuma senha inserida.";
                    else
                    {
                        if (TxtPassword.UseSystemPasswordChar)
                        {
                            var newP = string.Empty;

                            for (int n = 0; n < p.Length; n++) newP += '*';

                            p = newP;
                        }
                        t += "\nSenha inserida: " + p;
                    }
                }
                catch (Exception ex)
                {
                    t = "ERRO: " + ex.Message;
                    i = MessageBoxIcon.Error;
                }
                finally
                {
                    if (v == true)
                    {
                        MessageBox.Show(t, c, b, i);
                        BtnLeave_Click(sender, e);
                    }
                }
            }
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
