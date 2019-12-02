using BusinessLayer;
using PropsLayer;
using System;
using System.Data;

namespace WebThreeTierOfcMgtSystem
{
    public partial class editproduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProdProps p = new ProdProps();

            p.Prd_id = Request.QueryString["edtprd"];
            ProdBLL emp = new ProdBLL();
            DataTable dt = emp.searchProdBLL(p);
            if (dt.Rows.Count > 0)
            {
                p_id.Text = dt.Rows[0]["prd_id"].ToString();
                p_name.Text = dt.Rows[0]["prd_title"].ToString();
                p_price.Text = dt.Rows[0]["prd_price"].ToString();
                p_stock.Text = dt.Rows[0]["prd_stock"].ToString();
                expiry.Text = dt.Rows[0]["prd_expiry"].ToString();
                p_manuf.Text = dt.Rows[0]["prd_manufacturer"].ToString();
                hdnimg.Text = dt.Rows[0]["img"].ToString();
            }
            else
            {
                Response.Redirect("viewproducts.aspx?error=Sorry, Something Went Wrong....!");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ProdProps p = new ProdProps();

            p.Prd_id = p_id.Text;
            p.Prd_title = p_name.Text;
            p.Prd_price = p_price.Text;
            p.Prd_stock = p_stock.Text;
            p.Prd_expiry = expiry.Text;
            p.Prd_manufact = p_manuf.Text;
            if (image.HasFile)
            {
                String timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                String img_name = image.FileName.ToString();
                img_name = timeStamp + img_name;
                p.Prd_image = img_name;
                image.SaveAs(Server.MapPath("~/upload/") + img_name);
            }
            else
            {
                p.Prd_image = hdnimg.Text.ToString();
            }

            ProdBLL emp = new ProdBLL();
            if (emp.updateProdBLL(p) && emp.updatePImgBLL(p))
            {
                Response.Redirect("viewproducts.aspx?success=Product Updated Successfully");
            }
            else
            {
                Response.Redirect("viewproducts.aspx?error=Sorry, Something Went Wrong....!");
            }
        }
    }
}
