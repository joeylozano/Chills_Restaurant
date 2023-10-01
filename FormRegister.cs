﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chills_Restaurant
{
    public partial class FormRegister : Form
    {
        public static readonly string connectionString = "Data Source=LAPTOP-U9V72D48\\SQLEXPRESS01;Initial Catalog=Chills_Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection conn = new SqlConnection(connectionString);

        public FormRegister()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccounts formLogin = new FormAccounts();
            formLogin.Show();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                guna2MessageDialog1.Show("Please fill mandatory fields.");
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                guna2MessageDialog1.Show("Password does not match.");
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand("UserAdd", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@uPhone", txtContact.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@upass", txtPassword.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration Successfull");
            Clear();
        }


        void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}
