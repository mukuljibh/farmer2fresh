using Org.BouncyCastle.Pqc.Crypto.Falcon;
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
    public partial class Customer_dashboard : Form
    {
        public static Boolean flag = false;
        public static string l = "";
        public Customer_dashboard()
        {
            InitializeComponent();
            label2.Text = "Hello Customer: " + l;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new farmer_grid().ShowDialog();
        }

        private void Customer_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                MessageBox.Show("knock knock ! i am here with your order ! ");
                flag = false;
            }
            else
            {
                MessageBox.Show("Order is yet to pack or you have not place any order for now!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new customer_login().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new customer_feedback().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_dashboard().ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
