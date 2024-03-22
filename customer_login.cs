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

namespace WinFormsApp1
{
    public partial class customer_login : Form
    {
        public customer_login()
        {

            InitializeComponent();

        }

        private void customer_login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Customer_reg().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            String password = textBox2.Text;
            Customer_dashboard.l=username;
            
            string connectionString = "Data Source = DELL; Initial Catalog = mini; Integrated Security = True;";
            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to insert data
                    string insertQuery = "SELECT 1 FROM customer_reg WHERE username = @username AND password = @password";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {

                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string name = result.ToString();

                            MessageBox.Show("login successfuly");
                            this.Hide();
                            new Customer_dashboard().ShowDialog();

                            // Process the retrieved name as needed
                        }
                        else
                        {
                            MessageBox.Show("Invalid details");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();   
        }
    }
}
