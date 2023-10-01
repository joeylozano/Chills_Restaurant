namespace Chills_Restaurant
{
    partial class FormLogin
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGunaLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnGunaExit = new Guna.UI2.WinForms.Guna2Button();
            this.txtGunaUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGunaPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(372, 244);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Chills_Restaurant.Properties.Resources.user__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(120, 40);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(139, 128);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter user information.";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(38, 277);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 23);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // btnGunaLogin
            // 
            this.btnGunaLogin.AutoRoundedCorners = true;
            this.btnGunaLogin.BorderRadius = 21;
            this.btnGunaLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGunaLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGunaLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGunaLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGunaLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.btnGunaLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGunaLogin.ForeColor = System.Drawing.Color.White;
            this.btnGunaLogin.Location = new System.Drawing.Point(42, 479);
            this.btnGunaLogin.Name = "btnGunaLogin";
            this.btnGunaLogin.Size = new System.Drawing.Size(122, 45);
            this.btnGunaLogin.TabIndex = 2;
            this.btnGunaLogin.Text = "Login";
            this.btnGunaLogin.Click += new System.EventHandler(this.btnGunaLogin_Click);
            // 
            // btnGunaExit
            // 
            this.btnGunaExit.AutoRoundedCorners = true;
            this.btnGunaExit.BorderRadius = 21;
            this.btnGunaExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGunaExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGunaExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGunaExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGunaExit.FillColor = System.Drawing.Color.Firebrick;
            this.btnGunaExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGunaExit.ForeColor = System.Drawing.Color.White;
            this.btnGunaExit.Location = new System.Drawing.Point(194, 479);
            this.btnGunaExit.Name = "btnGunaExit";
            this.btnGunaExit.Size = new System.Drawing.Size(122, 45);
            this.btnGunaExit.TabIndex = 3;
            this.btnGunaExit.Text = "Exit";
            this.btnGunaExit.Click += new System.EventHandler(this.btnGunaExit_Click);
            // 
            // txtGunaUsername
            // 
            this.txtGunaUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGunaUsername.DefaultText = "";
            this.txtGunaUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGunaUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGunaUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGunaUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaUsername.Location = new System.Drawing.Point(42, 304);
            this.txtGunaUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGunaUsername.Name = "txtGunaUsername";
            this.txtGunaUsername.PasswordChar = '\0';
            this.txtGunaUsername.PlaceholderText = "";
            this.txtGunaUsername.SelectedText = "";
            this.txtGunaUsername.Size = new System.Drawing.Size(274, 41);
            this.txtGunaUsername.TabIndex = 7;
            // 
            // txtGunaPassword
            // 
            this.txtGunaPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGunaPassword.DefaultText = "";
            this.txtGunaPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGunaPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGunaPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGunaPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGunaPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGunaPassword.Location = new System.Drawing.Point(42, 408);
            this.txtGunaPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGunaPassword.Name = "txtGunaPassword";
            this.txtGunaPassword.PasswordChar = '●';
            this.txtGunaPassword.PlaceholderText = "";
            this.txtGunaPassword.SelectedText = "";
            this.txtGunaPassword.Size = new System.Drawing.Size(274, 41);
            this.txtGunaPassword.TabIndex = 8;
            this.txtGunaPassword.UseSystemPasswordChar = true;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "Chills Restaurant";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 557);
            this.Controls.Add(this.txtGunaPassword);
            this.Controls.Add(this.txtGunaUsername);
            this.Controls.Add(this.btnGunaExit);
            this.Controls.Add(this.btnGunaLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnGunaLogin;
        private Guna.UI2.WinForms.Guna2Button btnGunaExit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtGunaUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtGunaPassword;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}

