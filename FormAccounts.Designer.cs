namespace Chills_Restaurant
{
    partial class FormAccounts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label uPhoneLabel;
            System.Windows.Forms.Label addressLabel;
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnGunaRegister = new Guna.UI2.WinForms.Guna2Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsuserID = new System.Windows.Forms.ToolStripLabel();
            this.lblTitle = new System.Windows.Forms.ToolStripLabel();
            this.btnLookup = new System.Windows.Forms.ToolStripButton();
            this.comboBox = new System.Windows.Forms.ToolStripComboBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.chills_RestaurantDataSet3 = new Chills_Restaurant.Chills_RestaurantDataSet3();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Chills_Restaurant.Chills_RestaurantDataSet3TableAdapters.usersTableAdapter();
            this.tableAdapterManager = new Chills_Restaurant.Chills_RestaurantDataSet3TableAdapters.TableAdapterManager();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.uPhoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            usernameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            uPhoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chills_RestaurantDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.AutoRoundedCorners = true;
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.BorderRadius = 110;
            this.guna2GroupBox1.BorderThickness = 3;
            this.guna2GroupBox1.Controls.Add(usernameLabel);
            this.guna2GroupBox1.Controls.Add(this.usernameTextBox);
            this.guna2GroupBox1.Controls.Add(firstNameLabel);
            this.guna2GroupBox1.Controls.Add(this.firstNameTextBox);
            this.guna2GroupBox1.Controls.Add(lastNameLabel);
            this.guna2GroupBox1.Controls.Add(this.lastNameTextBox);
            this.guna2GroupBox1.Controls.Add(uPhoneLabel);
            this.guna2GroupBox1.Controls.Add(this.uPhoneTextBox);
            this.guna2GroupBox1.Controls.Add(addressLabel);
            this.guna2GroupBox1.Controls.Add(this.addressTextBox);
            this.guna2GroupBox1.Controls.Add(this.guna2PictureBox1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Empty;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(631, 241);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(222, 399);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.AutoRoundedCorners = true;
            this.guna2PictureBox1.BackgroundImage = global::Chills_Restaurant.Properties.Resources.user__1_;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.BorderRadius = 64;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(48, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(131, 145);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.AutoRoundedCorners = true;
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.BorderRadius = 110;
            this.guna2GroupBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2GroupBox2.BorderThickness = 3;
            this.guna2GroupBox2.Controls.Add(this.btnGunaRegister);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Empty;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(327, 241);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(222, 399);
            this.guna2GroupBox2.TabIndex = 15;
            // 
            // btnGunaRegister
            // 
            this.btnGunaRegister.AutoRoundedCorners = true;
            this.btnGunaRegister.BackgroundImage = global::Chills_Restaurant.Properties.Resources.add;
            this.btnGunaRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGunaRegister.BorderRadius = 110;
            this.btnGunaRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGunaRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGunaRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGunaRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGunaRegister.FillColor = System.Drawing.Color.Transparent;
            this.btnGunaRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGunaRegister.ForeColor = System.Drawing.Color.White;
            this.btnGunaRegister.Location = new System.Drawing.Point(0, 0);
            this.btnGunaRegister.Name = "btnGunaRegister";
            this.btnGunaRegister.Size = new System.Drawing.Size(222, 399);
            this.btnGunaRegister.TabIndex = 0;
            this.btnGunaRegister.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsuserID,
            this.lblTitle,
            this.btnLookup,
            this.comboBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1207, 171);
            this.toolStrip.TabIndex = 16;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsuserID
            // 
            this.tsuserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsuserID.ForeColor = System.Drawing.Color.White;
            this.tsuserID.Name = "tsuserID";
            this.tsuserID.Size = new System.Drawing.Size(0, 168);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(369, 168);
            this.lblTitle.Text = "Accounts";
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.Color.IndianRed;
            this.btnLookup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLookup.ForeColor = System.Drawing.Color.White;
            this.btnLookup.Image = global::Chills_Restaurant.Properties.Resources.search;
            this.btnLookup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(29, 168);
            this.btnLookup.Text = "Look Up";
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 171);
            this.comboBox.Click += new System.EventHandler(this.comboBox_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Firebrick;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(0, 171);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(1207, 43);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // chills_RestaurantDataSet3
            // 
            this.chills_RestaurantDataSet3.DataSetName = "Chills_RestaurantDataSet3";
            this.chills_RestaurantDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.chills_RestaurantDataSet3;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PositionCompanyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chills_Restaurant.Chills_RestaurantDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(14, 163);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(78, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(107, 160);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(100, 27);
            this.usernameTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(14, 198);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(83, 20);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(107, 195);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(15, 235);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(82, 20);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(107, 228);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // uPhoneLabel
            // 
            uPhoneLabel.AutoSize = true;
            uPhoneLabel.Location = new System.Drawing.Point(15, 264);
            uPhoneLabel.Name = "uPhoneLabel";
            uPhoneLabel.Size = new System.Drawing.Size(53, 20);
            uPhoneLabel.TabIndex = 11;
            uPhoneLabel.Text = "Phone:";
            // 
            // uPhoneTextBox
            // 
            this.uPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "uPhone", true));
            this.uPhoneTextBox.Location = new System.Drawing.Point(107, 261);
            this.uPhoneTextBox.Name = "uPhoneTextBox";
            this.uPhoneTextBox.ReadOnly = true;
            this.uPhoneTextBox.Size = new System.Drawing.Size(100, 27);
            this.uPhoneTextBox.TabIndex = 12;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(15, 297);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(65, 20);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(107, 294);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(100, 27);
            this.addressTextBox.TabIndex = 14;
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1207, 706);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAccounts";
            this.Load += new System.EventHandler(this.FormAccounts_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chills_RestaurantDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button btnGunaRegister;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tsuserID;
        private System.Windows.Forms.ToolStripButton btnLookup;
        private System.Windows.Forms.ToolStripLabel lblTitle;
        private System.Windows.Forms.ToolStripComboBox comboBox;
        private System.Windows.Forms.Button btnPrevious;
        private Chills_RestaurantDataSet3 chills_RestaurantDataSet3;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Chills_RestaurantDataSet3TableAdapters.usersTableAdapter usersTableAdapter;
        private Chills_RestaurantDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox uPhoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
    }
}