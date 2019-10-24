using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PropsLayer;
using BusinessLayer;
using System.Data;
using System.Collections;

namespace WebThreeTierOfcMgtSystem
{
    public partial class aa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ProdBLL p = new ProdBLL();
            Repeater1.DataSource = p.AllProdBLL();
            Repeater1.DataBind();
        }

    }
}