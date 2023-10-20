using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainEnterance
{
    public partial class frmMain : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A6C5CRN\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");
        public frmMain()
        {
            InitializeComponent();
        }

        private void occupancyRate()
        {
            try
            {
                conn.Open();

                // "Yes" olan odaların sayısını al
                string query = "SELECT COUNT(*) FROM Room WHERE room_free = 'True'";
                SqlCommand command = new SqlCommand(query, conn);
                int yesCount = (int)command.ExecuteScalar();

                // Toplam oda sayısını al
                query = "SELECT COUNT(*) FROM room";
                command = new SqlCommand(query, conn);
                int totalCount = (int)command.ExecuteScalar();

                // Doluluk oranını hesapla
                double occupancyRate = (double)yesCount / totalCount * 100;

                // Label kontrolüne doluluk oranını yaz
                progbar.Value = (int)occupancyRate;
                label7.Text = occupancyRate.ToString("0") + "%";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoteldbDataSet6.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hoteldbDataSet6.Room);
            occupancyRate();
            guna2DataGridView1.CellFormatting += guna2DataGridView1_CellFormatting;
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            frm_Staff frm_Staff = new frm_Staff();
            frm_Staff.Show();
        }
        public void roomAvailable()
        {

        }
        private void btn_client_Click(object sender, EventArgs e)
        {
            frmClient frmClient = new frmClient();
            frmClient.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/hotel.flamingo/");
        }

        private void btn_youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=crGIvJFoYlI");
        }

        private void btn_facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/flamingohotel/");
        }

        private void btn_twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/hotelflamingo");
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            frmReservation reser = new frmReservation();    
            reser.Show();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            frmRooms rooms = new frmRooms();
            rooms.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            guna2DataGridView1.RowTemplate.Height= 0;   
            if (e.ColumnIndex == 2) // room_free sütununun indeksini belirtmelisiniz
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool isRoomFree = (bool)e.Value;
                    if (isRoomFree)
                    {
                        // Oda boşsa, hücrenin arka plan rengini yeşil yap

                        guna2DataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.YellowGreen;
                        guna2DataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.YellowGreen; // Seçildiğinde de aynı renk olmasını sağla
                    }
                    else
                    {
                        // Oda doluysa, hücrenin arka plan rengini kırmızı yap
                        guna2DataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        guna2DataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightCoral;// Seçildiğinde de aynı renk olmasını sağlar
                    }
                }
            }
        }
    }
}
