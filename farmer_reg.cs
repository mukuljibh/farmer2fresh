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
    public partial class farmer_reg : Form
    {
        public farmer_reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new farmer_reg2().ShowDialog();
        }

        private void farmer_reg_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            

            string connectionString = "Data Source = DELL; Initial Catalog = mini; Integrated Security = True;";
            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to insert data
                    string insertQuery = "SELECT 1 FROM farmer_registration WHERE username = @username AND password = @password";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {

                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string name = result.ToString();

                            MessageBox.Show("login successfuly");
                            farmer_login.useru=username;
                            farmer_dashboard.l = username;
                            this.Hide();
                            new farmer_dashboard().ShowDialog();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }
    }
}
