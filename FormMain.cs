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
    public partial class FormMain : Form
    {
        string MainItem;
        string SubItem;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MainItem = "#1";
            MainOrder.Text = MainItem;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MainItem = "#2";
            MainOrder.Text = MainItem;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MainItem = "#3";
            MainOrder.Text = MainItem;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MainItem = "#4";
            MainOrder.Text = MainItem;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            MainItem = "#5";
            MainOrder.Text = MainItem;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            MainItem = "#6";
            MainOrder.Text = MainItem;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            SubItem = "#1";
            SubOrder.Text = SubItem;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            SubItem = "#2";
            SubOrder.Text = SubItem;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            SubItem = "#3";
            SubOrder.Text = SubItem;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            SubItem = "#4";
            SubOrder.Text = SubItem;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            SubItem = "#5";
            SubOrder.Text = SubItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MainItem, "You Have Ordered");
            MessageBox.Show(SubItem, "And");
        }
    }
}
