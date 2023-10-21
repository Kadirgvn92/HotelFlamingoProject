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
using System.Threading;

namespace MainEnterance
{
    public partial class frmForget : Form
    {
        public string code = GenerateVerificationCode(6);
        public frmForget()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-A6C5CRN\SQLEXPRESS;Initial Catalog=Hoteldb;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer_Tick(object sender, EventArgs e)
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
                string to, from, pass, mail;
                to = txt_ver_email.Text;
                from = "kadirgvn92@gmail.com";
                code = GenerateVerificationCode(6);
                mail = code;
                pass = "babu kmss hnog gsxa";
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = "Hello, Your verificaion code is : " + mail;
                message.Subject = "Hotel Flamingo Management - Verification Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Verification code sent successful! Go to Gmail and got the codee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ver_code.Enabled = true;
                    btn_verification.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //string verificationCode = GenerateVerificationCode(6);
                //MessageBox.Show($" Your Verification Code = {verificationCode}, Please Note Code..", "Verification Code", MessageBoxButtons.OK);
                //txt_ver_code.Text = verificationCode;
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
            
          if(txt_ver_code.Text == code)
            {
                frmMain frm = new frmMain();    
                frm.Show();
            }
        }

        private void txt_ver_code_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
