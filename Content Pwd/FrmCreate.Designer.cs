namespace Content_Pwd
{
    partial class FrmCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreate));
            this.LblSubject = new System.Windows.Forms.Label();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtContent = new System.Windows.Forms.TextBox();
            this.LblContent = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnLeave = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.BtnView = new System.Windows.Forms.Button();
            this.LblPlaceholder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSubject
            // 
            this.LblSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSubject.AutoSize = true;
            this.LblSubject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubject.Location = new System.Drawing.Point(19, 125);
            this.LblSubject.Name = "LblSubject";
            this.LblSubject.Size = new System.Drawing.Size(73, 19);
            this.LblSubject.TabIndex = 1;
            this.LblSubject.Text = "Assunto";
            // 
            // TxtSubject
            // 
            this.TxtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSubject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubject.Location = new System.Drawing.Point(22, 146);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(745, 26);
            this.TxtSubject.TabIndex = 2;
            // 
            // TxtContent
            // 
            this.TxtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContent.Location = new System.Drawing.Point(22, 205);
            this.TxtContent.Multiline = true;
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.Size = new System.Drawing.Size(745, 224);
            this.TxtContent.TabIndex = 4;
            // 
            // LblContent
            // 
            this.LblContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblContent.AutoSize = true;
            this.LblContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContent.Location = new System.Drawing.Point(19, 184);
            this.LblContent.Name = "LblContent";
            this.LblContent.Size = new System.Drawing.Size(85, 19);
            this.LblContent.TabIndex = 3;
            this.LblContent.Text = "Conteúdo";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(22, 468);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(572, 26);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.GotFocus += new System.EventHandler(this.TxtPassword_GotFocus);
            this.TxtPassword.LostFocus += new System.EventHandler(this.TxtPassword_LostFocus);
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(19, 447);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(159, 19);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "Senha do conteúdo";
            this.LblPlaceholder.Click += new System.EventHandler(this.TxtPassword_GotFocus);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCreate.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCreate.Image = global::Content_Pwd.Properties.Resources.Create;
            this.BtnCreate.Location = new System.Drawing.Point(528, 512);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(239, 76);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "CRIAR";
            this.BtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnLeave
            // 
            this.BtnLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLeave.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeave.Image = global::Content_Pwd.Properties.Resources.Leave;
            this.BtnLeave.Location = new System.Drawing.Point(22, 512);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(237, 76);
            this.BtnLeave.TabIndex = 10;
            this.BtnLeave.Text = "RETORNAR";
            this.BtnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLeave.UseVisualStyleBackColor = true;
            this.BtnLeave.Click += new System.EventHandler(this.BtnLeave_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRead.Enabled = false;
            this.BtnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRead.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRead.Image = global::Content_Pwd.Properties.Resources.Update;
            this.BtnRead.Location = new System.Drawing.Point(274, 512);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(238, 76);
            this.BtnRead.TabIndex = 9;
            this.BtnRead.Text = "ATUALIZAR";
            this.BtnRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRead.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PicLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicLogo.Image = global::Content_Pwd.Properties.Resources.Logo;
            this.PicLogo.Location = new System.Drawing.Point(22, 12);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(745, 100);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // BtnView
            // 
            this.BtnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnView.BackColor = System.Drawing.SystemColors.Control;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnView.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnView.Image = global::Content_Pwd.Properties.Resources.View;
            this.BtnView.Location = new System.Drawing.Point(600, 447);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(167, 47);
            this.BtnView.TabIndex = 7;
            this.BtnView.Text = "Bloquear";
            this.BtnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // LblPlaceholder
            // 
            this.LblPlaceholder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPlaceholder.AutoSize = true;
            this.LblPlaceholder.BackColor = System.Drawing.Color.White;
            this.LblPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblPlaceholder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.LblPlaceholder.Location = new System.Drawing.Point(25, 472);
            this.LblPlaceholder.Name = "LblPlaceholder";
            this.LblPlaceholder.Size = new System.Drawing.Size(355, 18);
            this.LblPlaceholder.TabIndex = 11;
            this.LblPlaceholder.Text = "Mantenha este campo vazio para nenhuma senha.";
            // 
            // FrmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 609);
            this.Controls.Add(this.LblPlaceholder);
            this.Controls.Add(this.BtnLeave);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtContent);
            this.Controls.Add(this.LblContent);
            this.Controls.Add(this.TxtSubject);
            this.Controls.Add(this.LblSubject);
            this.Controls.Add(this.PicLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fazer uma nova anotação";
            this.Load += new System.EventHandler(this.FrmCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label LblSubject;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.TextBox TxtContent;
        private System.Windows.Forms.Label LblContent;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnLeave;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Label LblPlaceholder;
    }
}