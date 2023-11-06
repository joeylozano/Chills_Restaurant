namespace menuitems2
{
    public partial class Form1 : Form
    {
        string Morder;
        string Sorder;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Morder = "1";
            MainOrder.Text = Morder;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Morder = "2";
            MainOrder.Text = Morder;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Morder = "3";
            MainOrder.Text = Morder;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Morder = "4";
            MainOrder.Text = Morder;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Morder = "5";
            MainOrder.Text = Morder;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Morder = "6";
            MainOrder.Text = Morder;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Sorder = "1";
            SubOrder.Text = Sorder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Sorder = "2";
            SubOrder.Text = Sorder;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Sorder = "3";
            SubOrder.Text = Sorder;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Sorder = "4";
            SubOrder.Text = Sorder;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Sorder = "5";
            SubOrder.Text = Sorder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Morder, "You have ordered: ");
            MessageBox.Show(Sorder, "And");

        }
    }
}