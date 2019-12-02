using BusinessLayer;
using PropsLayer;
using System;
using System.Linq;

namespace WebThreeTierOfcMgtSystem
{
    public partial class viewproducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProdBLL s = new ProdBLL();
            Repeater1.DataSource = s.AllProdBLL();
            Repeater1.DataBind();


            if (Request.Params.AllKeys.Contains("dltprd"))
            {
                ProdProps u = new ProdProps();
                u.Prd_id = Request.QueryString["dltprd"];
                ProdBLL ub = new ProdBLL();
                if (ub.deleteProdBLL(u))
                {
                    Response.Redirect("viewproducts.aspx?success=Deleted Successfully");
                }
                else
                {
                    Response.Redirect("viewproducts.aspx?error=Something Went Wrong....!");
                }
            }
        }
    }
}
