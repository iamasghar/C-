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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();

            p.E_id = txt_eid.Text;
            p.E_name = txt_name.Text;
            p.E_cell = txt_cell.Text;
            p.E_address = txt_address.Text;

            EmpBLL emp = new EmpBLL();
            if(emp.insertEmpBLL(p))
            {
                MessageBox.Show("Record Inserted Successfully");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
            }
            else
            {
                MessageBox.Show("Record Inserted Unsuccessfull");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();

            p.E_id = txt_eid.Text;
            p.E_name = txt_name.Text;
            p.E_cell = txt_cell.Text;
            p.E_address = txt_address.Text;

            EmpBLL emp = new EmpBLL();
            if (emp.updateEmpBLL(p))
            {
                MessageBox.Show("Record Updated Successfully");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
            }
            else
            {
                MessageBox.Show("Record Updated Unsuccessfull");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();

            p.E_id = txt_eid.Text;

            EmpBLL emp = new EmpBLL();
            if (emp.deleteEmpBLL(p))
            {
                MessageBox.Show("Record Deleted Successfully");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
            }
            else
            {
                MessageBox.Show("Record Deleted Unsuccessfull");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();

            p.E_id = txt_eid.Text;

            EmpBLL emp = new EmpBLL();
            DataTable dt = emp.searchEmpBLL(p);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Record Found..!");
                txt_name.Text = dt.Rows[0]["name"].ToString();
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
            new Customer().Show();
            this.Hide();
        }
    }
}
