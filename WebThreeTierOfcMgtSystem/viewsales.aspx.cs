using BusinessLayer;
using System;

namespace WebThreeTierOfcMgtSystem
{
    public partial class viewsales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SellBLL s = new SellBLL();
            Repeater1.DataSource = s.getSellBLL();
            Repeater1.DataBind();
        }
    }
}
