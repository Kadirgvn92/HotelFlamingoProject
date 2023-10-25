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

namespace MainEnterance
{
    public partial class frmClient : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A6C5CRN\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");
        
        public frmClient()
        {
            InitializeComponent();
        }
        public void populate()
        {
            conn.Open();
            string myQuery = "SELECT * FROM Client";
            SqlDataAdapter sda = new SqlDataAdapter(myQuery, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
            var dataSet = new DataTable();
            sda.Fill(dataSet);
            dtg_client.DataSource = dataSet;
            conn.Close();
        }


        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter2.Fill(this.hoteldbDataSet4.Client);

            populate();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Client VALUES('" + txt_clientId.Text + "' , '" + txt_clientName.Text + "', '" + txt_phone.Text + "','" + txt_email.Text + "' , '" + txt_country.SelectedItem.ToString() + "', '" + txt_address.Text + "','" + date_dob.Value.ToString("yyyy-MM-dd") + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client succesfully added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                populate();
            }catch(Exception ex)
            {
                MessageBox.Show("Plase make sure all fields are filled", "Info", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Client WHERE client_Id = " + txt_clientId.Text + "", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client succesfully Deleted", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
           

            if (txt_search.Text == "")
            {
                populate();
            }
            
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Client where client_name = '" + txt_search.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var dataSet = new DataTable();
                sda.Fill(dataSet);
                dtg_client.DataSource = dataSet;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_clientId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_clientId_Click(object sender, EventArgs e)
        {
            
             
        }

        private void txt_clientName_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_phone_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            
        }

        private void dtg_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_clientId.Text = dtg_client.SelectedRows[0].Cells[0].Value.ToString();
            txt_clientName.Text = dtg_client.SelectedRows[0].Cells[1].Value.ToString();
            txt_phone.Text = dtg_client.SelectedRows[0].Cells[2].Value.ToString();
            txt_email.Text = dtg_client.SelectedRows[0].Cells[3].Value.ToString();
            txt_country.SelectedItem = dtg_client.SelectedRows[0].Cells[4].Value.ToString();
            txt_address.Text = dtg_client.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Client SET  client_name = '" + txt_clientName.Text + "', client_phone = '" + txt_phone.Text + "', client_email = '" + txt_email.Text + "' , client_country = '" + txt_country.SelectedItem.ToString() + "', client_address = '" + txt_address.Text + "' WHERE client_Id = " + txt_clientId.Text + ";", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client succesfully updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Plase make sure all fields are filled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
