using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using PropsLayer;

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
        }
    }
}