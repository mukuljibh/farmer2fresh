using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class customer_purchase : Form
    {
        public static string fid = "";
        public int temp = 0;
        public customer_purchase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String pname = textBox1.Text;
            int qty = Convert.ToInt32(textBox2.Text);

            string connectionString = "Data Source = DELL; Initial Catalog = mini; Integrated Security = True;";
            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to insert data
                    string insertQuery = "SELECT price FROM product WHERE name = @pname and fuser=@fid";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {

                        command.Parameters.AddWithValue("@pname", pname);
                        command.Parameters.AddWithValue("@fid", fid);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string name = result.ToString();
                            int price = Convert.ToInt32(result);
                            int ans = price * qty;
                            temp = ans;

                            MessageBox.Show($"please pay {Convert.ToString(ans)} Rs for {pname} {qty} nos on delivery");
                           

                        }
                        else
                        {
                            MessageBox.Show("Sorry currently Out of Stock");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_purchase_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            string connectionString = "Data Source = DELL; Initial Catalog = mini; Integrated Security = True;";
            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to insert data
                    string updateQwery = "UPDATE farmer_registration set sales=(select sales from farmer_registration where username=@fid)+@temp where username=@fid";

                    using (SqlCommand command = new SqlCommand(updateQwery, connection))
                    {

                        command.Parameters.AddWithValue("@fid", fid);
                        command.Parameters.AddWithValue("@temp", temp);

                        object result = command.ExecuteScalar();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            farmer_dashboard.orders = true;
            MessageBox.Show("Your Order has been Placed Thank You");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new customer_login().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_dashboard().ShowDialog();
        }
    }
}
