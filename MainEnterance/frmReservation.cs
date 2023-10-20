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
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void num1_ValueChanged(object sender, EventArgs e)
        {
            int value;
            if(num1.Value == 2)
            {
                txt_customer2.Visible = true;
                lbl_customer2.Visible = true;
            } 
            if(num1.Value == 3)
            {
                txt_customer3.Visible = true;
                lbl_customer3.Visible = true;
            }

        }

        private void num_child_ValueChanged(object sender, EventArgs e)
        {
            int value;
            if (num_child.Value == 1)
            {
                txt_child1.Visible = true;
                lbl_child1.Visible = true;
                num_childAge1.Visible = true;
                lbl_childAge1.Visible = true;
            }
            if (num_child.Value == 2)
            {
                txt_child2.Visible = true;
                lbl_child2.Visible = true;
                num_childAge2.Visible = true;
                lbl_childAge2.Visible = true;
            }
            if (num_child.Value == 3)
            {
                txt_child3.Visible = true;
                lbl_child3.Visible = true;
                num_childAge3.Visible = true;
                lbl_childAge3.Visible = true;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {

        }

        private void frmReservation_Load(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
