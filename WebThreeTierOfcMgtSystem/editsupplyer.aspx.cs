using BusinessLayer;
using PropsLayer;
using System;
using System.Data;

namespace WebThreeTierOfcMgtSystem
{
    public partial class editsupplyer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SupProps up = new SupProps();
            up.S_id = Request.QueryString["edtsup"];
            SupBLL ub = new SupBLL();
            DataTable dt = ub.searchSupBLL(up);
            if (dt.Rows.Count > 0)
            {
                txt_sid.Text = dt.Rows[0]["sup_id"].ToString();
                txt_name.Text = dt.Rows[0]["name"].ToString();
                txt_cel.Text = dt.Rows[0]["cell"].ToString();
                txt_address.Text = dt.Rows[0]["address"].ToString();

            }
            else
            {
                Response.Redirect("viewsuppliers.aspx?error=Sorry, Something Went Wrong....!");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SupProps p = new SupProps();

            p.S_id = txt_sid.Text;
            p.S_name = txt_name.Text;
            p.S_cell = txt_cel.Text;
            p.S_address = txt_address.Text;

            SupBLL cus = new SupBLL();
            if (cus.updateSupBLL(p))
            {
                Response.Redirect("viewsuppliers.aspx?success=Supplier Updated Successfully");
            }
            else
            {
                Response.Redirect("viewsuppliers.aspx?error=Sorry, Something Went Wrong....!");
            }
        }
    }
}
