using System;
using System.Windows.Forms;

namespace Content_Pwd
{
    public partial class FrmRead : Form
    {
        public FrmRead()
        {
            InitializeComponent();
        }

        private void FrmRead_Load(object sender, EventArgs e)
        {
            PicLogo.Select();
            DgvContent_Load();
            DgvContent.ClearSelection();
        }

        private void DgvContent_Load()
        {
            DgvContent.Rows.Clear();
            if (Classes.Database.id != null)
            {
                for (int i = 0; i < Classes.Database.id.Length; i++)
                {
                    var u = Properties.Resources.Up;
                    var d = Properties.Resources.Down;
                    var p = Properties.Resources.Password;
                    var s = Classes.Database.subject[i];

                    if (i == 0)
                    {
                        u = Properties.Resources.Disabled_Up;
                        if (Classes.Database.id.Length == 1) d = Properties.Resources.Disabled_Down;
                    }
                    else if (i == (Classes.Database.id.Length - 1)) d = Properties.Resources.Disabled_Down;

                    if (Classes.Database.password[i] == string.Empty) p = null;
                    DgvContent.Rows.Add(i, u, d, s, p);
                }
            }

            DgvContent.ClearSelection();
        }

        private int DgvContent_Verify(string p = null)
        {
            if (string.IsNullOrWhiteSpace(p)) p = string.Empty;
            int i = 0;

            if (p != string.Empty)
            {
                if (TxtPassword.Text == string.Empty) i = 1;
                else if (TxtPassword.Text != p) i = 2;
            }

            return i;
        }

        private void DgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvContent.ClearSelection();

            var r = e.RowIndex;
            var c = e.ColumnIndex;

            if (r > -1 && c > -1)
            {
                var p = Classes.Database.password[r];
                Classes.Data.selected_id = r;

                if (c == 1)
                {
                    Classes.Data.Up();
                    DgvContent_Load();
                }
                else if (c == 2)
                {
                    Classes.Data.Down();
                    DgvContent_Load();
                }
                else if (c == 5)
                {
                    var t = "Por favor, verifique se a senha está correta.";
                    var ca = string.Empty;
                    var b = MessageBoxButtons.OK;
                    var i = MessageBoxIcon.Error;

                    if (DgvContent_Verify(p) == 0)
                    {
                        FrmCreate frmCreate = new FrmCreate();
                        frmCreate.ShowDialog();
                        DgvContent_Load();
                        DgvContent.Select();
                    }
                    else if (DgvContent_Verify(p) == 1)
                    {
                        t = "Este conteúdo é protegido por senha.\n\nPor favor, entre com uma senha no campo abaixo.";
                        i = MessageBoxIcon.Warning;

                        MessageBox.Show(t, ca, b, i);
                    }
                    else if (DgvContent_Verify(p) == 2) MessageBox.Show(t, ca, b, i);
                }
                else if (c == 6)
                {
                    var t = "Você tem certeza que deseja remover o conteúdo?";
                    var ca = string.Empty;
                    var b = MessageBoxButtons.YesNo;
                    var i = MessageBoxIcon.Question;

                    if (DgvContent_Verify(p) == 0)
                    {
                        DialogResult re = MessageBox.Show(t, ca, b, i);
                        if (re == DialogResult.Yes)
                        {
                            t = "O conteúdo foi removido com sucessso!";
                            ca = Classes.Database.subject[r];
                            b = MessageBoxButtons.OK;
                            i = MessageBoxIcon.Information;

                            Classes.Database.Delete();
                            MessageBox.Show(t, ca, b, i);
                            DgvContent_Load();
                        }
                    }
                    else if (DgvContent_Verify(p) == 1)
                    {
                        t = "Este conteúdo é protegido por senha.\n\nPor favor, entre com uma senha no campo abaixo.";
                        b = MessageBoxButtons.OK;
                        i = MessageBoxIcon.Warning;

                        MessageBox.Show(t, ca, b, i);
                    }
                    else if (DgvContent_Verify(p) == 2)
                    {
                        t = "Por favor, verifique se a senha está correta.";
                        b = MessageBoxButtons.OK;
                        i = MessageBoxIcon.Error;

                        MessageBox.Show(t, ca, b, i);
                    }
                }
                else
                {
                    var t = Classes.Database.content[r];
                    var ca = Classes.Database.subject[r];
                    var b = MessageBoxButtons.OK;
                    var i = MessageBoxIcon.Information;

                    if (DgvContent_Verify(p) == 1)
                    {
                        t = "Este conteúdo é protegido por senha.\n\nPor favor, entre com uma senha no campo abaixo.";
                        ca = string.Empty;
                        i = MessageBoxIcon.Warning;
                    }
                    else if (DgvContent_Verify(p) == 2)
                    {
                        t = "Por favor, verifique se a senha está correta.";
                        ca = string.Empty;
                        i = MessageBoxIcon.Error;
                    }

                    MessageBox.Show(t, ca, b, i);
                }
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            PicLogo.Select();
            if (TxtPassword.UseSystemPasswordChar) TxtPassword.UseSystemPasswordChar = false;
            else TxtPassword.UseSystemPasswordChar = true;
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Classes.Data.selected_id = -1;
        }
    }
}
