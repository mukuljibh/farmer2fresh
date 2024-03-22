using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class farmer_grid : Form
    {
        public farmer_grid()
        {
            InitializeComponent();
            
        }

        private void FetchDataAndDisplay()
        {
            try
            {

               
                string connectionString = "Data Source=DELL;Initial Catalog=mini;Integrated Security=True;";
                string selectQuery = "SELECT name,farm_name,contact, username as farmers FROM farmer_registration";  // Adjust the query based on your table structure

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set the DataGridView's DataSource to the DataTable
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["choose"].Index)
            {
                // Get the farmer name from the clicked row
                string farmerName = dataGridView1.Rows[e.RowIndex].Cells["farmers"].Value.ToString();

                // Show a MessageBox with the farmer name
                customer_purchase.fid = farmerName;
                this.Hide();
                new customer_purchase().ShowDialog();

            }
        }

        private void farmer_grid_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new customer_login().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FetchDataAndDisplay();
        }
    }
}
