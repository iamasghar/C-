using BusinessLayer;
using PropsLayer;
using System;

namespace WebThreeTierOfcMgtSystem
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            if (image.HasFile)
            {
                ProdProps p = new ProdProps();
                p.Prd_id = p_id.Text;
                p.Prd_title = p_name.Text;
                p.Prd_price = p_price.Text;
                p.Prd_stock = p_stock.Text;
                p.Prd_expiry = expiry.Text;
                p.Prd_manufact = p_manuf.Text;
                //p.Prd_image = DateTime.Now + files.FileName.ToString();
                //files.SaveAs(Server.MapPath("~/upload/") + p.Prd_image);
                //String imgpath = Request.PhysicalPath + "/upload/" + DateTime.Now + files.FileName.ToString();
                //p.Prd_image = imgpath;
                //files.SaveAs(imgpath);

                String timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                String img_name = timeStamp + image.FileName.ToString();
                p.Prd_image = img_name;
                image.SaveAs(Server.MapPath("~/upload/") + img_name);
                ProdBLL emp = new ProdBLL();
                if (emp.insertProdBLL(p))
                {
                    Response.Redirect("products.aspx?success=Product Added Successfully.");
                }
                else
                {
                    Response.Redirect("products.aspx?error=Sorry, Something Went Wrong....!");
                }
            }
            else
            {
                Response.Redirect("products.aspx?error=PLease upload a image.");
            }
        }

        //protected void Update_Click(object sender, EventArgs e)
        //{
        //    ProdProps p = new ProdProps();

        //    p.Prd_id = p_id.Text;
        //    p.Prd_title = p_title.Text;
        //    p.Prd_price = p_price.Text;
        //    p.Prd_stock = p_stock.Text;
        //    p.Prd_expiry = p_expiry.Text;
        //    p.Prd_manufact = p_manuf.Text;

        //    ProdBLL emp = new ProdBLL();
        //    if (emp.updateProdBLL(p))
        //    {
        //        Response.Write("<script>alert('Record Updated Successfully')</script>");
        //        p_id.Text = "";
        //        p_title.Text = "";
        //        p_price.Text = "";
        //        p_stock.Text = "";
        //        p_expiry.Text = "";
        //        p_manuf.Text = "";
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('Record Updated Unsuccessfull')</script>");
        //    }
        //}

        //protected void Delete_Click(object sender, EventArgs e)
        //{
        //    ProdProps p = new ProdProps();

        //    p.Prd_id = p_id.Text;
        //    ProdBLL emp = new ProdBLL();

        //    if (emp.deleteProdBLL(p))
        //    {
        //        Response.Write("<script>alert('Record Deleted Successfully')</script>");
        //        p_id.Text = "";
        //        p_title.Text = "";
        //        p_price.Text = "";
        //        p_stock.Text = "";
        //        p_expiry.Text = "";
        //        p_manuf.Text = "";
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('Record Deleted Unsuccessfull')</script>");
        //    }
        //}

        //protected void Show_Click(object sender, EventArgs e)
        //{
        //    ProdProps p = new ProdProps();

        //    p.Prd_id = p_id.Text;
        //    ProdBLL emp = new ProdBLL();
        //    DataTable dt = emp.searchProdBLL(p);
        //    if (dt.Rows.Count > 0)
        //    {
        //        //Response.Write("<script>alert('Record Found..!')</script>");
        //        hidn_id.Text = dt.Rows[0]["prd_id"].ToString();
        //        p_title.Text = dt.Rows[0]["prd_title"].ToString();
        //        p_price.Text = dt.Rows[0]["prd_price"].ToString();
        //        p_stock.Text = dt.Rows[0]["prd_stock"].ToString();
        //        p_expiry.Text = dt.Rows[0]["prd_expiry"].ToString();
        //        p_manuf.Text = dt.Rows[0]["prd_manufacturer"].ToString();
        //        Image1.ImageUrl = "/upload/" + dt.Rows[0]["img"].ToString();
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('Record Not Found..!')</script>");
        //    }
        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    String timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
        //    String img_name = FileUpload1.FileName.ToString();

        //    {
        //        img_name = timeStamp + img_name;
        //        ProdProps p = new ProdProps();
        //        p.Prd_image = img_name;
        //        p.Prd_id = hidn_id.Text.ToString();
        //        FileUpload1.SaveAs(Server.MapPath("~/upload/") + img_name);
        //        ProdBLL emp = new ProdBLL();
        //        if (emp.updatePImgBLL(p))
        //        {
        //            Response.Write("<script>alert('Image Updated Successfully')</script>");
        //            hidn_id.Text = "";
        //        }
        //        else
        //        {
        //            Response.Write("<script>alert('Something Went Wrong..!')</script>");
        //        }
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('Image Not Found')</script>");
        //    }

        //}
    }
}
