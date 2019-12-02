using BusinessLayer;
using PropsLayer;
using System;

namespace WebThreeTierOfcMgtSystem
{
    public partial class adduser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String password = pwd.Text;
            String cpassword = cpwd.Text;
            String uemail = email.Text;
            if (password.Equals(cpassword))
            {
                funs f = new funs();
                String Hashed_pwd = f.SHA_256_salted(password, uemail).ToString();
                String cHashed_pwd = f.SHA_256_salted(cpassword, uemail).ToString();
                if (Hashed_pwd.Equals(cHashed_pwd))
                {
                    UserProps u = new UserProps();
                    u.U_id = u_id.Text;
                    u.U_name = name.Text;
                    u.U_cnic = cnic.Text;
                    u.U_cell = cell.Text;
                    u.U_email = uemail;
                    u.U_password = Hashed_pwd;
                    u.U_address = address.Text;
                    u.U_access_level = access_level.SelectedValue.ToString();
                    UserBLL ubbb = new UserBLL();
                    if (ubbb.insertUserBLL(u))
                    {
                        Session["U_access_level"] = u.U_access_level;
                        Session["U_id"] = u.U_id;
                        Session["U_name"] = u.U_name;
                        Response.Redirect("adduser.aspx?success=User Registered Successfull");
                    }
                    else
                    {
                        Response.Redirect("adduser.aspx?error=Something Went Wrong....!  User Registerion Unsuccessfull");
                    }
                }
                else
                {
                    Response.Redirect("adduser.aspx?error=Hash Doesn't Match.");
                }
            }
            else
            {
                Response.Redirect("adduser.aspx?error=Password Doesn't Match.");
            }
        }
    }
}
