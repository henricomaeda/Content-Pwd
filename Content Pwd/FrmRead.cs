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
            DgvContent.Rows.Add(0, "Assunto 1...", Properties.Resources.Password);
            DgvContent.Rows.Add(1, "Assunto 2...");
            DgvContent.Rows.Add(2, "Assunto 3...", Properties.Resources.Password);
            DgvContent.Rows.Add(3, "Assunto 4...");
            DgvContent.ClearSelection();
        }

        private void DgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvContent.ClearSelection();

            var r = e.RowIndex;
            var c = e.ColumnIndex;
            var cell = DgvContent.Rows[r].Cells[c].Value;

            if (c == 3)
            {
                MessageBox.Show("Alterar");
            }
            else if (c == 4)
            {
                MessageBox.Show("Remover");
            }
            else
            {
                MessageBox.Show(r.ToString());
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
    }
}
