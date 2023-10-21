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
using System.Web.UI.WebControls;

namespace MainEnterance
{
    public partial class frm_Staff : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A6C5CRN\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");

        public frm_Staff()
        {
            InitializeComponent();
        }
        
        public void populate()
        {
            conn.Open();
            String myQuery = "SELECT * FROM staff";
            SqlDataAdapter sda = new SqlDataAdapter(myQuery, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
            var dataSet = new DataTable();
            sda.Fill(dataSet);
            dt_staff.DataSource = dataSet;

            conn.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoteldbDataSet2.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter1.Fill(this.hoteldbDataSet2.Staff);
            populate();
            txt_password.UseSystemPasswordChar = true;
            
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dt_staff.SelectedRows[0].Cells[0].Value.ToString();
            txt_username.Text = dt_staff.SelectedRows[0].Cells[1].Value.ToString();
            txt_password.Text = dt_staff.SelectedRows[0].Cells[2].Value.ToString();
            txt_name.Text = dt_staff.SelectedRows[0].Cells[3].Value.ToString();
            txt_phone.Text = dt_staff.SelectedRows[0].Cells[4].Value.ToString();
            txt_email.Text = dt_staff.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO staff VALUES('" + txt_id.Text + "' , '" + txt_username.Text + "', '" + txt_password.Text + "','" +
                    txt_name.Text + "' , '" + txt_phone.Text + "', '" + txt_email.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff succesfully Added");
                conn.Close();
                populate();
                if(txt_id.Text == null || txt_username.Text == null || txt_password == null || txt_phone.Text == null || txt_name.Text == null || txt_email.Text == null)
                {
                    MessageBox.Show("There is blank data in form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("There is error with data enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM staff where staff_name = '" + txt_search.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
            var dataSet = new DataTable();
            sda.Fill(dataSet);
            dt_staff.DataSource = dataSet;
            conn.Close();
            if (txt_search.Text == "")
            {
                populate();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE staff SET  staff_username = '" + txt_username.Text + "', staff_password = '" + txt_password.Text + "', staff_name = '" + txt_name.Text + "' , staff_phone = '" + txt_phone.Text + "', staff_email = '" + txt_email.Text + "' WHERE Id = " + txt_id.Text + ";", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff succesfully updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool isPasswordVisible = true;
        private void txt_password_IconRightClick(object sender, EventArgs e)
        {
            
            if (isPasswordVisible)
            {
                // Eğer şifre görünürse, şifreyi gizle
                txt_password.UseSystemPasswordChar = true; 
            }
            else
            {
                // Eğer şifre gizliyse, şifreyi göster
                txt_password.UseSystemPasswordChar = false; 
            }

            isPasswordVisible = !isPasswordVisible; 
        }
    }
}
