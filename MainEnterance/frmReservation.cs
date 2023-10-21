using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MainEnterance
{
    public partial class frmReservation : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A6C5CRN\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");
        public frmReservation()
        {
            InitializeComponent();
        }

        private void num1_ValueChanged(object sender, EventArgs e)
        {
            numAdultEnable();
        }
        public void populate()
        {
            conn.Open();
            string myQuery = "SELECT * FROM ReservationView";
            SqlDataAdapter sda = new SqlDataAdapter(myQuery, conn);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
            var dataSet = new DataTable();
            sda.Fill(dataSet);
            dg_reserve.DataSource = dataSet;
            conn.Close();
        }
        private void numAdultEnable()
        {
            if (num1.Value == 1)
            {
                txt_customer2.Enabled = false;
                txt_customer3.Enabled = false;
            }
            if (num1.Value == 2)
            {
                txt_customer2.Enabled = true;
                txt_customer3.Enabled = false;
            }
            if (num1.Value == 3)
            {
                txt_customer2.Enabled = true;
                txt_customer3.Enabled = true;
            }
        }

        private void numChildEnable()
        {
            if(num_child.Value == 0)
            {
                txt_child1.Enabled = false;
                num_childAge1.Enabled = false;
                lbl_childAge1.Enabled = false;

                txt_child2.Enabled = false;
                num_childAge2.Enabled = false;
                lbl_childAge2.Enabled = false;

                txt_child3.Enabled = false;
                num_childAge3.Enabled = false;
                lbl_childAge3.Enabled = false;

            }
            if (num_child.Value == 1)
            {
                txt_child1.Enabled = true;
                num_childAge1.Enabled = true;
                lbl_childAge1.Enabled = true;

                txt_child2.Enabled = false;
                num_childAge2.Enabled = false;
                lbl_childAge2.Enabled = false;

                txt_child3.Enabled = false;
                num_childAge3.Enabled = false;
                lbl_childAge3.Enabled = false;
            }
            if (num_child.Value == 2)
            {
                txt_child2.Enabled = true;
                num_childAge2.Enabled = true;
                lbl_childAge2.Enabled = true;

                txt_child3.Enabled = false;
                num_childAge3.Enabled = false;
                lbl_childAge3.Enabled = false;
            }
            if (num_child.Value == 3)
            {
                txt_child3.Enabled = true;
                num_childAge3.Enabled = true;
                lbl_childAge3.Enabled = true;
            }
        }
        private void num_child_ValueChanged(object sender, EventArgs e)
        {
            numChildEnable();
        }


        private void btn_reserve_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Reservation VALUES('" + txt_customer1.Text + "' , '" +  txt_room_number.Text + "','" +  txt_reserveType.SelectedItem.ToString() + "', '" + 
                num1.Value.ToString() + "','" + num_child.Value.ToString() + "' , '" + check_in_date.Value.ToString("yyyy-MM-dd") + "', '" + check_out_date.Value.ToString("yyyy-MM-dd") + "','" +
                lbl_price.Text + "', '" + lbl_price.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client succesfully added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoteldbDataSet8.ReservationView' table. You can move, or remove it, as needed.
            this.reservationViewTableAdapter.Fill(this.hoteldbDataSet8.ReservationView);
            // TODO: This line of code loads data into the 'hoteldbDataSet7.Reservation' table. You can move, or remove it, as needed
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Click(object sender, EventArgs e)
        {

        }
        private void txt_cardNumber_TextChanged(object sender, EventArgs e)
        {
            // Kredi kartı numarası formatını düzenle
            string input = txt_cardNumber.Text.Replace(" ", "").Replace("-", ""); // Boşluk ve tireleri kaldır
            if (input.Length > 0)
            {
                input = string.Join("", input.ToCharArray().Select((c, i) => (i + 1) % 4 == 0 ? c + " " : c.ToString())).Trim();
            }
            txt_cardNumber.Text = input;
            txt_cardNumber.SelectionStart = input.Length; // Kursoru metin sonuna taşı
        }

        private void txt_expriy_TextChanged(object sender, EventArgs e)
        {
            string input = txt_expriy.Text.Replace("/", "").Trim(); // Eğik çizgileri ve boşlukları kaldır
            if (input.Length > 0)
            {
                if (input.Length > 4)
                {
                    input = input.Substring(0, 4); // İlk dört karakteri al
                }
                if (input.Length > 2)
                {
                    input = input.Insert(2, "/"); // İlk iki karakterin sonuna bir eğik çizgi ekle
                }
            }
            txt_expriy.Text = input;
            txt_expriy.SelectionStart = input.Length; // Kursoru metin
        }

        private void txt_cardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam veya kontrol karakterlerine izin ver
            }
        }

        private void txt_cardName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Sadece harf, boşluk veya kontrol karakterlerine izin ver
            }
        }

        private void txt_expriy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam veya kontrol karakterlerine izin ver
            }
        }

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam veya kontrol karakterlerine izin ver
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = radio_card.Checked;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_checkRooms_Click(object sender, EventArgs e)
        {
            frmAvailableRooms frmAvailableRooms = new frmAvailableRooms();
            frmAvailableRooms.Show();
        }
    }
}
