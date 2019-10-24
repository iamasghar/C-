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
    public partial class supplyers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SupBLL s = new SupBLL();
            DataTable dtt = s.AllSupBLL();
            GridView1.DataSource = dtt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SupProps p = new SupProps();

            p.S_id = txt_sid.Text;
            p.S_name = txt_name.Text;
            p.S_cell = txt_cell.Text;
            p.S_address = txt_address.Text;

            SupBLL cus = new SupBLL();
            if (cus.insertSupBLL(p))
            {
                massege("Record Inserted Successfully");
                txt_sid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
            }
            else
            {
                massege("Record Inserted Unsuccessfull");
            }
        }

        public void massege(String s)
        {
            Response.Write("<script>alert('" + s + "');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SupProps p = new SupProps();

            p.S_id = txt_sid.Text;
            p.S_name = txt_name.Text;
            p.S_cell = txt_cell.Text;
            p.S_address = txt_address.Text;

            SupBLL cus = new SupBLL();
            if (cus.updateSupBLL(p))
            {
                massege("Record Updated Successfully");
                txt_sid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
            }
            else
            {
                massege("Record Updated Unsuccessfull");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SupProps p = new SupProps();

            p.S_id = txt_sid.Text;

            SupBLL cus = new SupBLL();
            if (cus.deleteSupBLL(p))
            {
                massege("Record Deleted Successfully");
                txt_sid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
            }
            else
            {
                massege("Record Deleted Unsuccessfull");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SupProps p = new SupProps();

            p.S_id = txt_sid.Text;

            SupBLL cus = new SupBLL();
            DataTable dt = cus.searchSupBLL(p);
            if (dt.Rows.Count > 0)
            {
                massege("Record Found..!");
                txt_name.Text = dt.Rows[0]["name"].ToString();
                txt_cell.Text = dt.Rows[0]["cell"].ToString();
                txt_address.Text = dt.Rows[0]["address"].ToString();
            }
            else
            {
                massege("Record Not Found..!");
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
            }
        }
    }
}