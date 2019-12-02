using BusinessLayer;
using PropsLayer;
using System;

namespace WebThreeTierOfcMgtSystem
{
    public partial class supplyers : System.Web.UI.Page
    {

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
                Response.Redirect("supplyers.aspx?success=Record Inserted Successfully");
                txt_sid.Text = "";
                txt_name.Text = "";
                txt_cell.Text = "";
                txt_address.Text = "";
            }
            else
            {
                Response.Redirect("supplyers.aspx?error=Record Inserted Unsuccessfull");
            }
        }
    }
}
