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
    public partial class viewcustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserProps up = new UserProps();
            up.U_access_level = "3";
            UserBLL s = new UserBLL();
            Repeater1.DataSource = s.ALevelUserBLL(up);
            Repeater1.DataBind();
        }
    }
}