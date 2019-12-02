using BusinessLayer;
using PropsLayer;
using System;
using System.Linq;

namespace WebThreeTierOfcMgtSystem
{
    public partial class viewadmins : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserProps up = new UserProps();
            up.U_access_level = "1";
            UserBLL s = new UserBLL();
            Repeater1.DataSource = s.ALevelUserBLL(up);
            Repeater1.DataBind();

            if (Request.Params.AllKeys.Contains("dltadmn"))
            {
                UserProps u = new UserProps();
                u.U_id = Request.QueryString["dltadmn"];
                UserBLL ub = new UserBLL();
                if (ub.deleteUserBLL(u))
                {
                    Response.Redirect("viewadmins.aspx?success=Deleted Successfully");
                }
                else
                {
                    Response.Redirect("viewadmins.aspx?error=Something Went Wrong....!");
                }
            }
        }
    }
}
