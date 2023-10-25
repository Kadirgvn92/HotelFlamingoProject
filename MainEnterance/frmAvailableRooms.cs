using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainEnterance
{
    public partial class frmAvailableRooms : Form
    {
        public frmAvailableRooms()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AvailableRooms_Load(object sender, EventArgs e)
        {
            this.roomTableAdapter1.Fill(this.hoteldbDataSet10.Room);
            // TODO: This line of code loads data into the 'hoteldbDataSet6.Room' table. You can move, or remove it, as needed.
            guna2DataGridView1.CellFormatting += guna2DataGridView1_CellFormatting;

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            guna2DataGridView1.RowTemplate.Height = 0;
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
