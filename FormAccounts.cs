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

namespace Chills_Restaurant
{
    public partial class FormAccounts : Form
    {
        public FormAccounts()
        {
            InitializeComponent();
            fillcomboBox();
        }


        public static readonly string connectionString = "Data Source=LAPTOP-U9V72D48\\SQLEXPRESS01;Initial Catalog=Chills_Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection conn = new SqlConnection(connectionString);

        public void fillcomboBox()
        {
            string sql = "select * from users";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader myreader;

            conn.Open();
            myreader = cmd.ExecuteReader();
            while (myreader.Read())
            {
                string username = myreader.GetString(1);
                comboBox.Items.Add(username);
            }
        }


        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chills_RestaurantDataSet);
        }


        private void FormAccounts_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.chills_RestaurantDataSet.users);
        }


        private void btnGunaRegister_MouseHover(object sender, EventArgs e)
        {
            btnGunaRegister.BackColor = Color.White;
        }

        private void btnGunaRegister_MouseLeave(object sender, EventArgs e)
        {
            btnGunaRegister.BackColor = Color.FromArgb(32, 38, 71); // ****add the color you want here.**
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            conn.Close();
        }


        private void btnLookup_Click(object sender, EventArgs e)
        {
            string userString = this.comboBox.Text;
            this.usersTableAdapter.FillByusername(this.chills_RestaurantDataSet.users, userString);
        }


        private void comboBox_Click(object sender, EventArgs e)
        {
            
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
