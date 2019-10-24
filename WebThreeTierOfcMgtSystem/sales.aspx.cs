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
    public partial class sales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (!IsPostBack)
            {
                DisplayData()
            }
            */

            ProdBLL p = new ProdBLL();
            DataTable dt = p.AllProdBLL();
            if (dt.Rows.Count > 0)
            {
                //products.Items.Clear();
                for (int i=0;i< dt.Rows.Count; i++)
                {
                    products.Items.Add(dt.Rows[i]["prd_title"].ToString());
                }
            }
            else
            {
                Response.Write("<script>alert('Record Not Found..!')</script>");
            }


            SellBLL s = new SellBLL();
            DataTable dtt = s.getSellBLL();
            GridView1.DataSource = dtt;
            GridView1.DataBind();
        }

        protected void Show_Click(object sender, EventArgs e)
        {
            /*
            ProdProps p = new ProdProps();

            p.Prd_title = products.SelectedItem.ToString();
            ProdBLL emp = new ProdBLL();
            DataTable dt = emp.getProdBLL(p);
            if (dt.Rows.Count > 0)
            {
                price.Text = dt.Rows[0]["prd_price"].ToString();
                stock.Text = dt.Rows[0]["prd_stock"].ToString();
            }
            else
            {
                Response.Write("<script>alert('Record Not Found..!')</script>");
            }
            */
        }
        

        protected void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdProps p = new ProdProps();

            p.Prd_title = products.SelectedItem.ToString();
            SellBLL emp = new SellBLL();
            DataTable dt = emp.getProdBLL(p);
            if (dt.Rows.Count > 0)
            {
                price.Text = dt.Rows[0]["prd_price"].ToString();
                stock.Text = dt.Rows[0]["prd_stock"].ToString();
            }
            else
            {
                price.Text = "";
                stock.Text = "";
            }
        }

        protected void Sell_Click(object sender, EventArgs e)
        {
            success.Text = "okk";
            SellProps sp = new SellProps();
            sp.Trx_id = trxid.Text.ToString();
            sp.P_title = products.SelectedItem.ToString();
            sp.P_price = price.Text.ToString();
            sp.P_quantity = quantaty.Text.ToString();
            sp.P_date = date.Text.ToString();
            sp.P_sold_by = soldby.Text.ToString();
            SellBLL sb = new SellBLL();
            if (sb.sellBLL(sp))
            {
                Response.Write("<script>alert('Transection Successfull')</script>");

            }
            else
            {
                Response.Write("<script>alert('Transection Unsuccessfull')</script>");
            }
            trxid.Text = "";
            products.SelectedIndex = 0;
            price.Text = "";
            quantaty.Text = "";
            date.Text = "";
            soldby.Text = "";
        }
    }
}