using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class farmer_dashboard : Form
    {
        public static Boolean orders = false;
        public static int sales = 0;
        public static string feedback = "";
        public static string l = "";
       
        

        public farmer_dashboard()
        {
            InitializeComponent();
            label2.Text = "Welcome Back :"+l;
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
                    string Selectquery = "SELECT sales FROM farmer_registration WHERE username = @l ";

                    using (SqlCommand command = new SqlCommand(Selectquery, connection))
                    {

                        command.Parameters.AddWithValue("@l", l);
                       
                        object result = command.ExecuteScalar();

                       
                            string sales = result.ToString();
                        
                            MessageBox.Show("Total Sales : " + sales);
                        
                       
                            

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new farmer_login().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (orders)
            {
                MessageBox.Show("Please pack the item deliver it to Customer");
                Customer_dashboard.flag = true;
                orders = false;
            }
            else
            {
                MessageBox.Show("No orders Yet");

            }
        }

        private void farmer_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new farmer_reg().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (feedback=="")
            {
                MessageBox.Show("No reviews Yet!");
            }
            else
            {
                MessageBox.Show("Customer Review : " + feedback);
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
