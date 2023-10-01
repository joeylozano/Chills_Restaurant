using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            FormRegister formLogin = new FormRegister();
            formLogin.Show();
        }
    }
}
