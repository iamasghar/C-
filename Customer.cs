using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropsLayer;
using BusinessLayer;

namespace ThreeTierMgtSystem_1701_02_17_09_19_
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            CusProps p = new CusProps();

            p.C_id = txt_eid.Text;
            p.C_name = txt_name.Text;
            p.C_cell = txt_cell.Text;
            p.C_address = txt_address.Text;
            p.C_cnic = cnic.Text;

            CusBLL cus = new CusBLL();
            if (cus.insertCusBLL(p))
            {
                MessageBox.Show("Record Inserted Successfully");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                cnic.Text = "";
            }
            else
            {
                MessageBox.Show("Record Inserted Unsuccessfull");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CusProps p = new CusProps();

            p.C_id = txt_eid.Text;
            p.C_name = txt_name.Text;
            p.C_cell = txt_cell.Text;
            p.C_address = txt_address.Text;
            p.C_cnic = cnic.Text;

            CusBLL cus = new CusBLL();
            if (cus.updateCusBLL(p))
            {
                MessageBox.Show("Record Updated Successfully");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                cnic.Text = "";
            }
            else
            {
                MessageBox.Show("Record Updated Unsuccessfull");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CusProps p = new CusProps();

            p.C_id = txt_eid.Text;

            CusBLL cus = new CusBLL();
            if (cus.deleteCusBLL(p))
            {
                MessageBox.Show("Record Deleted Successfully");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                cnic.Text = "";
            }
            else
            {
                MessageBox.Show("Record Deleted Unsuccessfull");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CusProps p = new CusProps();

            p.C_id = txt_eid.Text;

            CusBLL cus = new CusBLL();
            DataTable dt = cus.searchCusBLL(p);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Record Found..!");
                txt_name.Text = dt.Rows[0]["name"].ToString();
                cnic.Text = dt.Rows[0]["cnic"].ToString();
                txt_cell.Text = dt.Rows[0]["cell"].ToString();
                txt_address.Text = dt.Rows[0]["address"].ToString();
            }
            else
            {
                MessageBox.Show("Record Not Found..!");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
