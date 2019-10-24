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
    public partial class EmployeeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpBLL pp = new EmpBLL();
            DataTable dtt = pp.AllEmpBLL();
            GridView1.DataSource = dtt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();

            p.E_id = txt_eid.Text;
            p.E_name = txt_name.Text;
            p.E_cell = txt_cell.Text;
            p.E_address = txt_address.Text;
            p.E_email = txt_email.Text;
            p.E_password = txt_password.Text;

            EmpBLL emp = new EmpBLL();
            if (emp.insertEmpBLL(p))
            {
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                txt_email.Text = "";
                txt_password.Text = "";
                Response.Write("<script>alert('Record Inserted Successfull')</script>");
            }
            else
            {
                Response.Write("<script>alert('Record Inserted Unsuccessfull')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();

            p.E_id = txt_eid.Text;
            p.E_name = txt_name.Text;
            p.E_cell = txt_cell.Text;
            p.E_address = txt_address.Text;
            p.E_email = txt_email.Text;
            p.E_password = txt_password.Text;

            EmpBLL emp = new EmpBLL();
            if (emp.updateEmpBLL(p))
            {
                Response.Write("<script>alert('Record Updated Successfully')</script>");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                txt_email.Text = "";
                txt_password.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Record Updated Unsuccessfull')</script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();

            p.E_id = txt_eid.Text;

            EmpBLL emp = new EmpBLL();
            if (emp.deleteEmpBLL(p))
            {
                Response.Write("<script>alert('Record Deleted Successfully')</script>");
                txt_eid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
                txt_email.Text = "";
                txt_password.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Record Deleted Unsuccessfull')</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            EmpProps p = new EmpProps();

            p.E_id = txt_eid.Text;

            EmpBLL emp = new EmpBLL();
            DataTable dt = emp.searchEmpBLL(p);
            if (dt.Rows.Count > 0)
            {
                Response.Write("<script>alert('Record Found..!')</script>");
                txt_name.Text = dt.Rows[0]["name"].ToString();
                txt_cell.Text = dt.Rows[0]["cell"].ToString();
                txt_address.Text = dt.Rows[0]["address"].ToString();
                txt_email.Text = dt.Rows[0]["email"].ToString();
                txt_password.Text = dt.Rows[0]["password"].ToString();
            }
            else
            {
                Response.Write("<script>alert('Record Not Found..!')</script>");
            }
        }
    }
}