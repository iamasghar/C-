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
    public partial class purchases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ProdBLL p = new ProdBLL();
            DataTable dt = p.AllProdBLL();
            if (dt.Rows.Count > 0)
            {
                //products.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    products.Items.Add(dt.Rows[i]["prd_title"].ToString());
                }
            }
            else
            {
                Response.Write("<script>alert('Products Not Found..!')</script>");
            }

            SupBLL s = new SupBLL();
            DataTable dtb = s.AllSupBLL();
            if (dtb.Rows.Count > 0)
            {
                //supply.Items.Clear();
                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    supply.Items.Add(dtb.Rows[i]["name"].ToString());
                }
            }
            else
            {
                Response.Write("<script>alert('Supplyers Not Found..!')</script>");
            }


            PurBLL pp = new PurBLL();
            DataTable dtt = pp.getPurBLL();
            GridView1.DataSource = dtt;
            GridView1.DataBind();

        }

        protected void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdProps p = new ProdProps();

            p.Prd_title = products.SelectedItem.ToString();
            PurBLL emp = new PurBLL();
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
            PurProps sp = new PurProps();
            sp.Trx_id = trxid.Text.ToString();
            sp.P_title = products.SelectedItem.ToString();
            sp.P_price = price.Text.ToString();
            sp.P_quantity = quantaty.Text.ToString();
            sp.P_date = date.Text.ToString();
            sp.P_pur_by = soldby.Text.ToString();
            sp.P_supplyer = supply.SelectedItem.ToString();
            PurBLL sb = new PurBLL();
            if (sb.PurcBLL(sp))
            {
                Response.Write("<script>alert('Transection Successfull')</script>");
                trxid.Text = "";
                products.SelectedIndex = 0;
                price.Text = "";
                quantaty.Text = "";
                date.Text = "";
                soldby.Text = "";
                supply.SelectedIndex = 0;
            }
            else
            {
                Response.Write("<script>alert('Transection Unsuccessfull')</script>");
            }
        }

        protected void Show_Click(object sender, EventArgs e)
        {

        }
    }
}