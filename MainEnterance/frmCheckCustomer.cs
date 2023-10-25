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
    public partial class frmCheckCustomer : Form
    {
        public frmCheckCustomer()
        {
            InitializeComponent();
        }

        private void CheckCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoteldbDataSet15.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.hoteldbDataSet15.Client);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
