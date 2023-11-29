using Guna.UI2.WinForms;
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
    public partial class FormPIN : Form
    {
        int count = 0;  
        public FormPIN()
        {
            InitializeComponent();
        }

        private void btnGunaPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccounts formAccounts = new FormAccounts();
            formAccounts.Show();
        }

        private void btnGunaLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidPIN(txtGunaPIN.Text, txtGunaUsername.Text) == false)
            {
                guna2MessageDialog1.Show("Invalid PIN");
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
                FormMain formMain = new FormMain();
                formMain.Show();
            }
        }
    }
}
