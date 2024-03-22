using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class customer_feedback : Form
    {
        public customer_feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            farmer_dashboard.feedback = textBox1.Text;
            MessageBox.Show("Thank you for the Feedback");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            new customer_login().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_dashboard().ShowDialog();
        }
    }
}
