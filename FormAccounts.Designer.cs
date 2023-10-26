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
            System.Windows.Forms.Label lblFirstName;
            System.Windows.Forms.Label lblLastName;
            System.Windows.Forms.Label lblAddress;
            this.lblusername = new System.Windows.Forms.Label();
            this.lbluPhone = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chills_RestaurantDataSet = new Chills_Restaurant.Chills_RestaurantDataSet();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtuPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnGunaRegister = new Guna.UI2.WinForms.Guna2Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsuserID = new System.Windows.Forms.ToolStripLabel();
            this.lblTitle = new System.Windows.Forms.ToolStripLabel();
            this.btnLookup = new System.Windows.Forms.ToolStripButton();
            this.comboBox = new System.Windows.Forms.ToolStripComboBox();
            this.usersTableAdapter = new Chills_Restaurant.Chills_RestaurantDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new Chills_Restaurant.Chills_RestaurantDataSetTableAdapters.TableAdapterManager();
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chills_RestaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(14, 198);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(83, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(14, 231);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(82, 20);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(14, 297);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(65, 20);
            lblAddress.TabIndex = 13;
            lblAddress.Text = "Address:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(14, 165);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(78, 20);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "Username:";
            // 
            // lbluPhone
            // 
            this.lbluPhone.AutoSize = true;
            this.lbluPhone.Location = new System.Drawing.Point(14, 264);
            this.lbluPhone.Name = "lbluPhone";
            this.lbluPhone.Size = new System.Drawing.Size(53, 20);
            this.lbluPhone.TabIndex = 11;
            this.lbluPhone.Text = "Phone:";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.AutoRoundedCorners = true;
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.BorderRadius = 110;
            this.guna2GroupBox1.BorderThickness = 3;
            this.guna2GroupBox1.Controls.Add(this.lblusername);
            this.guna2GroupBox1.Controls.Add(this.txtusername);
            this.guna2GroupBox1.Controls.Add(lblFirstName);
            this.guna2GroupBox1.Controls.Add(this.txtFirstName);
            this.guna2GroupBox1.Controls.Add(lblLastName);
            this.guna2GroupBox1.Controls.Add(this.txtLastName);
            this.guna2GroupBox1.Controls.Add(this.lbluPhone);
            this.guna2GroupBox1.Controls.Add(this.txtuPhone);
            this.guna2GroupBox1.Controls.Add(lblAddress);
            this.guna2GroupBox1.Controls.Add(this.txtAddress);
            this.guna2GroupBox1.Controls.Add(this.guna2PictureBox1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Empty;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(5)))), ((int)(((byte)(126)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(630, 220);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(222, 399);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // txtusername
            // 
            this.txtusername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "username", true));
            this.txtusername.Location = new System.Drawing.Point(103, 162);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(100, 27);
            this.txtusername.TabIndex = 4;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.chills_RestaurantDataSet;
            // 
            // chills_RestaurantDataSet
            // 
            this.chills_RestaurantDataSet.DataSetName = "Chills_RestaurantDataSet";
            this.chills_RestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(103, 195);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(100, 27);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(103, 228);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(100, 27);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtuPhone
            // 
            this.txtuPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "uPhone", true));
            this.txtuPhone.Location = new System.Drawing.Point(103, 261);
            this.txtuPhone.Name = "txtuPhone";
            this.txtuPhone.ReadOnly = true;
            this.txtuPhone.Size = new System.Drawing.Size(100, 27);
            this.txtuPhone.TabIndex = 12;
            this.txtuPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(103, 294);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(100, 27);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.guna2GroupBox2.Location = new System.Drawing.Point(326, 220);
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
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Chills_Restaurant.Chills_RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1207, 732);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccounts";
            this.Text = "FormAccounts";
            this.Load += new System.EventHandler(this.FormAccounts_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chills_RestaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Chills_RestaurantDataSet chills_RestaurantDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Chills_RestaurantDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private Chills_RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtuPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbluPhone;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button btnGunaRegister;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel tsuserID;
        private System.Windows.Forms.ToolStripButton btnLookup;
        private System.Windows.Forms.ToolStripLabel lblTitle;
        private System.Windows.Forms.ToolStripComboBox comboBox;
    }
}