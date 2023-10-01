using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chills_Restaurant
{
    public partial class FormLogin : Form
    {
        int count = 0;

        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnGunaExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnGunaLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txtGunaUsername.Text, txtGunaPassword.Text) == false)
            {
                guna2MessageDialog1.Show("Invalid Username or Password");
                if (count++ >= 2)
                {
                    guna2MessageDialog1.Show("Failed all 3 login attempts.");
                    Application.Exit();
                }
                return;
            }
            else
            {
                this.Hide();
                FormAccounts formRegister = new FormAccounts();
                formRegister.Show();
            }

        }
    }
}
