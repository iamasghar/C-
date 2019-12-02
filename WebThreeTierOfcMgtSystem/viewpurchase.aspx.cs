using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace WebThreeTierOfcMgtSystem
{
    public partial class viewpurchase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PurBLL pp = new PurBLL();
            Repeater1.DataSource = pp.getPurBLL();
            Repeater1.DataBind();
        }
    }
}
