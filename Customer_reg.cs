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
    public partial class Customer_reg : Form
    {
        public Customer_reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = textBox1.Text;
            string contact = textBox2.Text;
            string username = textBox3.Text;
            string password = textBox4.Text;
            if (username == "" || password == "" || username == "" || contact == "")
            {
                MessageBox.Show("please submit all details");
                return;
            }
            string connectionString = "Data Source = DELL; Initial Catalog = mini; Integrated Security = True;";
            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to insert data
                    string insertQuery = "INSERT INTO customer_reg (Name, Contact, Username, Password) VALUES (@Name, @Contact, @Username, @Password)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Registration successful Proceed to Login.");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Choose different Username");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void Customer_reg_Load(object sender, EventArgs e)
        {

        }
    }
}
