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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using MainEnterance;

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

        private void num_child_ValueChanged(object sender, EventArgs e)
        {

        }
        public void totalPrice()
        {
            string roomNumber = txt_room_number.Text;
            decimal roomPrice = 0;
            string reserveType = txt_reserveType.SelectedItem.ToString();
            decimal boardingPrice = 0;

            if (reserveType == "All Inclusive")
            {
                boardingPrice = 50;
            }
            else if (reserveType == "Full Board")
            {
                boardingPrice = 30;
            }
            else if (reserveType == "Half Board")
            {
                boardingPrice = 10;
            }

            try
            {
                conn.Open();
                string query = "SELECT room_price FROM Room WHERE room_number = @roomNumber";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@roomNumber", roomNumber);

                    // Sorguyu çalıştırın ve sonucu alın
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            roomPrice = Convert.ToDecimal(reader["room_price"]);
                        }
                    }
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Invalid input. Please check your information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DateTime checkInDate = check_in_date.Value;
            DateTime checkOutDate = check_out_date.Value;
            TimeSpan stayDuration = checkOutDate - checkInDate;
            int nightsStayed = stayDuration.Days;

            // Örnek oda fiyatları ve kurallar
            decimal childDiscount = 0.5M; // Çocuklar için indirim (örneğin yüzde 50)
            decimal extraAdultCharge = 30; // Ekstra yetişkinler için ücret

            // Kullanıcıdan gelen yetişkin ve çocuk sayıları
            int adultCount = Convert.ToInt32(num1.Value);
            int childCount = Convert.ToInt32(num_child.Value);

            // Kullanıcıdan gelen boarding type (konaklama türü) verisi
            string boardingType = txt_reserveType.SelectedItem.ToString();

            // Toplam fiyat hesaplama
            decimal totalPrice = (roomPrice * adultCount) + (roomPrice * childCount * childDiscount);

            // Ekstra yetişkinlerin ücretini ekleyin (örneğin 2 yetişkin ücretsiz, ekstra yetişkinler için ücret alın)
            if (adultCount > 2)
            {
                totalPrice += extraAdultCharge * (adultCount - 1) * nightsStayed;
            }

            // Boarding fiyatını hesaplayın ve ekleyin (örneğin Full Board için $30 ekleyin)
            if(boardingType == "All Inclusive")
            {
                decimal fullBoardPrice = 50; // Örnek fiyat
                totalPrice += fullBoardPrice * nightsStayed;
            }
            else if (boardingType == "Full Board")
            {
                decimal fullBoardPrice = 30; // Örnek fiyat
                totalPrice += fullBoardPrice * nightsStayed;
            }
            else if (boardingType == "Half Board")
            {
                decimal halfBoardPrice = 15; // Örnek fiyat
                totalPrice += halfBoardPrice * nightsStayed;
            }

            string formattedValue = totalPrice.ToString("0.00");
            lbl_price.Text = formattedValue;

        }

        private void roomReserve()
        {
            int selectedRoomNumber = Convert.ToInt32(txt_room_number.Text);
            string updateQuery = "UPDATE Room SET room_free = 0 WHERE room_number = @SelectedRoomNumber";
            SqlCommand cmdRoom = new SqlCommand(updateQuery, conn);
            cmdRoom.Parameters.AddWithValue("@SelectedRoomNumber", selectedRoomNumber);

            int affectedRows = cmdRoom.ExecuteNonQuery(); // Odayı rezerve et (room_free'yi 1 yap)

            if (affectedRows > 0)
            {
                // Değişiklikler kaydedildi.
                MessageBox.Show("Oda başarıyla rezerve edildi.");
            }
            else
            {
                // Değişiklikler kaydedilemedi veya oda bulunamadı.
                MessageBox.Show("Oda rezerve edilemedi. Lütfen tekrar deneyin.");
            }

        }
        private void btn_reserve_Click(object sender, EventArgs e)
        {
            if (radio_cash.Checked == false && radio_card.Checked == false)
            {
                MessageBox.Show("Please choose the payment method as cash or as credit card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (radio_cash.Checked)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Reservation VALUES('" + txt_customer1.Text + "' , '" + txt_room_number.Text + "','" + txt_reserveType.SelectedItem.ToString() + "', '" +
                    num1.Value.ToString() + "','" + num_child.Value.ToString() + "' , '" + check_in_date.Value.ToString("yyyy-MM-dd") + "', '" + check_out_date.Value.ToString("yyyy-MM-dd") + "','" +
                    lbl_price.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation successful! Your booking is confirmed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    roomReserve();



                    conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (radio_card.Checked)
            {
                if (txt_cardName.Text == "" && txt_cardNumber.Text == "" && txt_expriy.Text == "" && txt_cvc.Text == "")
                {
                    MessageBox.Show("Make sure all Credit Card fields are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        conn.Open();

                        SqlCommand cmd1 = new SqlCommand("INSERT INTO Reservation VALUES('" + txt_customer1.Text + "' , '" + txt_room_number.Text + "','" + txt_reserveType.SelectedItem.ToString() + "', '" +
                        num1.Value.ToString() + "','" + num_child.Value.ToString() + "' , '" + check_in_date.Value.ToString("yyyy-MM-dd") + "', '" + check_out_date.Value.ToString("yyyy-MM-dd") + "','" +
                        lbl_price.Text + "')", conn);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Reservation successful! Your booking is confirmed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        roomReserve();

                        if (checkBox1.Checked)
                        {
                            SqlCommand cmd = new SqlCommand("Insert into CreditCard Values('" + txt_cardName.Text + "', '" + txt_cardNumber.Text + "', '" + txt_expriy.Text + "', '" + txt_cvc.Text + "')", conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Credit Card is saved successfully !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        conn.Close();
                        populate();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input. Please check your information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoteldbDataSet14.ReservationView' table. You can move, or remove it, as needed.
            this.reservationViewTableAdapter.Fill(this.hoteldbDataSet14.ReservationView);
            // TODO: This line of code loads data into the 'hoteldbDataSet13.ReservationView' table. You can move, or remove it, as needed.
            populate();
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
            txt_expriy.SelectionStart = input.Length; 
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

        private void txt_customer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_customer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam veya kontrol karakterlerine izin ver
            }
        }

        private void txt_room_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam veya kontrol karakterlerine izin ver
            }

        }
        private void btn_getTotal_Click(object sender, EventArgs e)
        {
            try
            {
                totalPrice();
                lbl_price.Visible = true;
                label15.Visible = true;
            }
            catch (Exception ex)
            {
                lbl_price.Visible = false;
            }

        }

        private void btn_reserve_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btn_reserve, "Please make sure all fields are filled.");
        }

        private void btn_reserve_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btn_reserve, string.Empty);
        }

        private void btn_checkCustomer_Click(object sender, EventArgs e)
        {
            frmCheckCustomer frmCheckCustomer = new frmCheckCustomer();
            frmCheckCustomer.Show();
        }
    }
}
