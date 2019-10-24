using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PropsLayer;
using BusinessLayer;
using System.Data;

namespace WebThreeTierOfcMgtSystem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CusBLL pp = new CusBLL();
            DataTable dtt = pp.AllCusBLL();
            GridView1.DataSource = dtt;
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
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
                massege("Record Inserted Successfully");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                cnic.Text = "";
            }
            else
            {
                massege("Record Inserted Unsuccessfull");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
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
                massege("Record Updated Successfully");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                cnic.Text = "";
            }
            else
            {
                massege("Record Updated Unsuccessfull");
            }   
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CusProps p = new CusProps();

            p.C_id = txt_eid.Text;

            CusBLL cus = new CusBLL();
            if (cus.deleteCusBLL(p))
            {
                massege("Record Deleted Successfully");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                cnic.Text = "";
            }
            else
            {
                massege("Record Deleted Unsuccessfull");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            CusProps p = new CusProps();

            p.C_id = txt_eid.Text;

            CusBLL cus = new CusBLL();
            DataTable dt = cus.searchCusBLL(p);
            if (dt.Rows.Count > 0)
            {
                massege("Record Found..!");
                txt_name.Text = dt.Rows[0]["name"].ToString();
                cnic.Text = dt.Rows[0]["cnic"].ToString();
                txt_cell.Text = dt.Rows[0]["cell"].ToString();
                txt_address.Text = dt.Rows[0]["address"].ToString();
            }
            else
            {
                massege("Record Not Found..!");
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                cnic.Text = "";
            }
        }
        public void massege(String s)
        {
            Response.Write("<script>alert('" + s + "');</script>");
        }
    }
}