using System;

namespace WebThreeTierOfcMgtSystem
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            funs f = new funs();
            //String timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            //String img_name = timeStamp + files.FileName.ToString();
            ////files.SaveAs($"upload/{files.FileName}");
            //Response.Write("<script>alert('" + img_name + "');</script>");
            //files.SaveAs(Server.MapPath("~/upload/") + img_name);
            String a = f.TripleDesEncrypt("Hello");
            String b = f.TripleDesDecrypt(a);
            Response.Write("<script>alert('" + a + " = > " + b + "');</script>");
        }
    }
}
