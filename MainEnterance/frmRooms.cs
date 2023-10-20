using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace MainEnterance
{
    public partial class frmRooms : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A6C5CRN\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");

        public frmRooms()
        {
            InitializeComponent();
        }
        private void frmRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoteldbDataSet6.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter1.Fill(this.hoteldbDataSet6.Room);
        }

        public void populate()
        {
            conn.Open();
            String myQuery = "SELECT * FROM Room";
            SqlDataAdapter sda = new SqlDataAdapter(myQuery, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
            var dataSet = new DataTable();
            sda.Fill(dataSet);
            dg_room.DataSource = dataSet;
            conn.Close();
        }

        private void dg_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_room_number.Text = dg_room.SelectedRows[0].Cells[1].Value.ToString();
            combo_room_type.SelectedItem = dg_room.SelectedRows[0].Cells[2].Value.ToString();
            txt_room_price.Text = dg_room.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void dg_room_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Room VALUES('" + txt_room_number.Text + "' , '" + combo_room_type.SelectedItem.ToString() + "' ,'" + txt_room_price.Text + "', 'False')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room succesfully added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Room SET room_type = '" + combo_room_type.SelectedItem.ToString() + "' , room_price = '"+ txt_room_price.Text + "' WHERE room_number = '" + txt_room_number.Text + "';", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room succesfully updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
