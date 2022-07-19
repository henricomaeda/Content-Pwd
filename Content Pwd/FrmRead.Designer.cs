namespace Content_Pwd
{
    partial class FrmRead
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRead));
            this.DgvContent = new System.Windows.Forms.DataGridView();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnLeave = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.Column_00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_02 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_03 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_04 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvContent
            // 
            this.DgvContent.AllowUserToAddRows = false;
            this.DgvContent.AllowUserToDeleteRows = false;
            this.DgvContent.AllowUserToResizeColumns = false;
            this.DgvContent.AllowUserToResizeRows = false;
            this.DgvContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvContent.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DgvContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvContent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvContent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvContent.ColumnHeadersHeight = 50;
            this.DgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_00,
            this.Column_01,
            this.Column_02,
            this.Column_03,
            this.Column_04});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvContent.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvContent.EnableHeadersVisualStyles = false;
            this.DgvContent.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.DgvContent.Location = new System.Drawing.Point(22, 152);
            this.DgvContent.MultiSelect = false;
            this.DgvContent.Name = "DgvContent";
            this.DgvContent.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvContent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvContent.RowHeadersVisible = false;
            this.DgvContent.RowTemplate.Height = 40;
            this.DgvContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvContent.Size = new System.Drawing.Size(796, 386);
            this.DgvContent.TabIndex = 0;
            this.DgvContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContent_CellClick);
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(265, 558);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(175, 22);
            this.LblPassword.TabIndex = 12;
            this.LblPassword.Text = "Senha do conteúdo";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(269, 584);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(496, 29);
            this.TxtPassword.TabIndex = 13;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Alterar";
            this.dataGridViewImageColumn1.Image = global::Content_Pwd.Properties.Resources.Change;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Remover";
            this.dataGridViewImageColumn2.Image = global::Content_Pwd.Properties.Resources.Delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 80;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Content_Pwd.Properties.Resources.Delete;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 40;
            // 
            // BtnView
            // 
            this.BtnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnView.BackColor = System.Drawing.SystemColors.Control;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnView.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnView.Image = global::Content_Pwd.Properties.Resources.View;
            this.BtnView.Location = new System.Drawing.Point(770, 566);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(48, 47);
            this.BtnView.TabIndex = 14;
            this.BtnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnLeave
            // 
            this.BtnLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLeave.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeave.Image = global::Content_Pwd.Properties.Resources.Leave;
            this.BtnLeave.Location = new System.Drawing.Point(22, 554);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(237, 59);
            this.BtnLeave.TabIndex = 11;
            this.BtnLeave.Text = "RETORNAR";
            this.BtnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLeave.UseVisualStyleBackColor = true;
            this.BtnLeave.Click += new System.EventHandler(this.BtnLeave_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PicLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicLogo.Image = global::Content_Pwd.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(22, 21);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(796, 114);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // Column_00
            // 
            this.Column_00.HeaderText = "Identificador";
            this.Column_00.Name = "Column_00";
            this.Column_00.ReadOnly = true;
            this.Column_00.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_00.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_00.Visible = false;
            this.Column_00.Width = 90;
            // 
            // Column_01
            // 
            this.Column_01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_01.HeaderText = "Assunto";
            this.Column_01.Name = "Column_01";
            this.Column_01.ReadOnly = true;
            this.Column_01.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_02
            // 
            this.Column_02.HeaderText = "";
            this.Column_02.Image = global::Content_Pwd.Properties.Resources.Null;
            this.Column_02.Name = "Column_02";
            this.Column_02.ReadOnly = true;
            this.Column_02.Width = 30;
            // 
            // Column_03
            // 
            this.Column_03.HeaderText = "";
            this.Column_03.Image = global::Content_Pwd.Properties.Resources.Change;
            this.Column_03.Name = "Column_03";
            this.Column_03.ReadOnly = true;
            this.Column_03.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_03.Width = 40;
            // 
            // Column_04
            // 
            this.Column_04.HeaderText = "";
            this.Column_04.Image = global::Content_Pwd.Properties.Resources.Delete;
            this.Column_04.Name = "Column_04";
            this.Column_04.ReadOnly = true;
            this.Column_04.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_04.Width = 40;
            // 
            // FrmRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 634);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.BtnLeave);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.DgvContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar anotações";
            this.Load += new System.EventHandler(this.FrmRead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvContent;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Button BtnLeave;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_00;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_01;
        private System.Windows.Forms.DataGridViewImageColumn Column_02;
        private System.Windows.Forms.DataGridViewImageColumn Column_03;
        private System.Windows.Forms.DataGridViewImageColumn Column_04;
    }
}