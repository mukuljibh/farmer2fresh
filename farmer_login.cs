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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{

    public partial class farmer_login : Form
    {
        public static String useru = "";
        public farmer_login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void Set(string d)
        {
            useru = d;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string quantity = textBox2.Text;
            int price = Convert.ToInt32(textBox3.Text);

            string connectionString = "Data Source = DELL; Initial Catalog = mini; Integrated Security = True;";
            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to insert data
                    string insertQuery = "INSERT INTO product (fuser, name,quantity,price) VALUES (@useru, @name, @quantity,@price)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@useru", useru);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@price", price);


                        // Execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show("added");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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
            new farmer_reg().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;


            string connectionString = "Data Source = DELL; Initial Catalog = mini; Integrated Security = True;";
            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to insert data
                    string insertQuery = "delete from product where name=@name and fuser=@useru ";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@useru", useru);


                        // Execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show($"{name} has been discared");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void farmer_login_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new farmer_dashboard().ShowDialog();


        }
    }
}
