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
using System.Net.Mail;
using System.Net;

namespace MainEnterance
{
    public partial class frmForget : Form
    {
        public frmForget()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A6C5CRN\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_verification_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT staff_email FROM staff", conn);
            var dataSet = new DataTable();
            sda.Fill(dataSet);

            bool emailFound = false;

            foreach (DataRow row in dataSet.Rows)
            {
                string email = row["staff_email"].ToString();
                if (txt_ver_email.Text == email)
                {
                    emailFound = true;
                    break;
                }

            }

            conn.Close();

            if (emailFound)
            {
                string verificationCode = GenerateVerificationCode(6);
                MessageBox.Show($" Your Verification Code = {verificationCode}, Please Note Code..", "Verification Code", MessageBoxButtons.OK);
                txt_ver_code.Text = verificationCode;
            }
            else
            {
                MessageBox.Show("Email not found in the database", "Error");
            }
        }

        static string GenerateVerificationCode(int length)
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder code = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                code.Append(chars[index]);
            }

            return code.ToString();
        }

        private void txt_ver_email_Click(object sender, EventArgs e)
        {
            txt_ver_email.Clear();
        }

        private void txt_ver_code_Click(object sender, EventArgs e)
        {
            txt_ver_code.Clear();
        }

        private void btn_zeroize_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Your account has been succesfully zeroized", "Verification", MessageBoxButtons.OK);
        }

        private void txt_ver_code_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
