using System;
using System.IO;
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

                    if (i == 0) u = Properties.Resources.Disabled_Up;
                    else if (i == 0 && i == (Classes.Database.id.Length - 1))
                    {
                        u = Properties.Resources.Disabled_Up;
                        d = Properties.Resources.Disabled_Down;
                    }
                    else if (i == (Classes.Database.id.Length - 1)) d = Properties.Resources.Disabled_Down;

                    if (Classes.Database.password[i] == string.Empty) p = null;
                    DgvContent.Rows.Add(i, u, d, s, p);
                }
            }

            DgvContent.ClearSelection();
        }

        private void DgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvContent.ClearSelection();

            var r = e.RowIndex;
            var c = e.ColumnIndex;

            if (r > -1 && c > -1)
            {
                var v = DgvContent.Rows[r].Cells[c].Value;
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
                    MessageBox.Show("Alterar");
                }
                else if (c == 6)
                {
                    MessageBox.Show("Remover");
                }
                else
                {
                    MessageBox.Show("ID: " + r.ToString());
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
