using BusinessLayer;
using PropsLayer;
using System;
using System.Linq;

namespace WebThreeTierOfcMgtSystem
{
    public partial class viewsuppliers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SupBLL s = new SupBLL(); ;
            Repeater1.DataSource = s.AllSupBLL();
            Repeater1.DataBind();

            if (Request.Params.AllKeys.Contains("dltsup"))
            {
                SupProps p = new SupProps();
                p.S_id = Request.QueryString["dltsup"];
                SupBLL ss = new SupBLL();
                if (ss.updateSupBLL(p))
                {
                    Response.Redirect("viewsuppliers.aspx?success=Deleted Successfully");
                }
                else
                {
                    Response.Redirect("viewsuppliers.aspx?error=Something Went Wrong....!");
                }
            }
        }
    }
}
