using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chills_Restaurant
{
    public partial class FormRegister : Form
    {
        public static readonly string connectionString = "Server=tcp:chills-server.database.windows.net,1433;Initial Catalog=Chills_Restaurant;Persist Security Info=False;User ID=chilladmin;Password=Foxtrot@92;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection conn = new SqlConnection(connectionString);

        string selectedData;
        public FormRegister(string selectedData)
        {
            InitializeComponent();
            this.selectedData = selectedData;
            FillBoxCombo();
        }


        public void FillBoxCombo()
        {
            if (selectedData == "Manager")
            {
                BoxCombo.Items.AddRange(new object[] { "Manager", "Employee", "Client" });
            }
            else if (selectedData == "Employee")
            {
                BoxCombo.Items.AddRange(new object[] { "Employee", "Client" });
            }
            else if (selectedData == "Client")
            {
                BoxCombo.Items.AddRange(new object[] { "Client" });
            }
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccounts formAccounts = new FormAccounts();
            formAccounts.Show();
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
            else
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("AddUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@uPhone", txtContact.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@upass", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@PIN", txtPIN.Text.Trim());
                cmd.Parameters.AddWithValue("@PositionID", BoxCombo.SelectedItem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfull");
                Clear();
            }
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
            txtPIN.Text = "";
            BoxCombo.Text = "";
        }

    }
}
