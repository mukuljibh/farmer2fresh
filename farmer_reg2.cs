using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Tls;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.Contracts;
using System.Xml.Linq;


namespace WinFormsApp1
{

    public partial class farmer_reg2 : Form
    {
        public farmer_reg2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string contact = textBox2.Text;
            string username = textBox3.Text;
            string password = textBox4.Text;
            string farm_name = textBox5.Text;
            if (username =="" || password==""|| username==""||farm_name=="" || contact=="")
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
                    string insertQuery = "INSERT INTO farmer_registration (Name, Contact, Username, Password,farm_name,sales) VALUES (@Name, @Contact, @Username, @Password,@farm_name,0)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@farm_name", farm_name);

                        // Execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Registration successful Proceed to Login.");
                        this.Hide();
                        new farmer_reg().ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Choose different Username");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                    string insertQuery = "Select name from farmer_registration where contact='mukul'";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {


                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string name = result.ToString();
                            MessageBox.Show(name);
                            // Process the retrieved name as needed
                        }
                        else
                        {
                            MessageBox.Show("not found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void farmer_reg2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new farmer_reg().ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
