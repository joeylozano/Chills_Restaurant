using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chills_Restaurant
{
    public partial class FormAccounts : Form
    {
        String selectedData;

        public FormAccounts(string selectedData)
        {
            InitializeComponent();
            this.selectedData = selectedData;
            FillcomboBox();            
        }

        public FormAccounts()
        {
            InitializeComponent();
        }

        public string Sqls()
        {
            if (selectedData == "Client")
            {
                return "SELECT * FROM users WHERE PositionID NOT IN ('Manager', 'Employee')";
            }
            else if (selectedData == "Employee")
            {
                return "SELECT * FROM users WHERE PositionID NOT IN ('Manager')";
            }
            else if (selectedData == "Manager")
            {
                return "SELECT * FROM users";
            }

            return "";
        }


        public void FillcomboBox()
        {
            string connectionString = "Server=tcp:chills-server.database.windows.net,1433;Initial Catalog=Chills_Restaurant;Persist Security Info=False;User ID=chilladmin;Password=Foxtrot@92;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string sql = Sqls();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader myreader;

            if (!string.IsNullOrEmpty(sql))
            {
                conn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string username = myreader.GetString(1);
                    comboBox.Items.Add(username);
                }
                myreader.Close();
                conn.Close();
            }
        }


        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chills_RestaurantDataSet3);
        }


        private void btnGunaRegister_MouseHover(object sender, EventArgs e)
        {
            btnGunaRegister.BackColor = Color.White;
        }


        private void btnGunaRegister_MouseLeave(object sender, EventArgs e)
        {
            btnGunaRegister.BackColor = Color.FromArgb(32, 38, 71); // add color you want here
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister(selectedData);
            formRegister.Show();
        }


        private void btnLookup_Click(object sender, EventArgs e)
        {
            string userString = this.comboBox.Text;
            this.usersTableAdapter.FillByusername(this.chills_RestaurantDataSet3.users, userString);
        }


        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
