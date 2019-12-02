using BusinessLayer;
using PropsLayer;
using System;
using System.Data;

namespace WebThreeTierOfcMgtSystem
{
    public partial class edituser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserProps up = new UserProps();
            up.U_id = Request.QueryString["edtusr"];
            UserBLL ub = new UserBLL();
            DataTable dt = ub.searchUserBLL(up);
            if (dt.Rows.Count > 0)
            {
                u_id.Text = dt.Rows[0]["u_id"].ToString();
                name.Text = dt.Rows[0]["name"].ToString();
                cnic.Text = dt.Rows[0]["cnic"].ToString();
                cell.Text = dt.Rows[0]["cell"].ToString();
                email.Text = dt.Rows[0]["email"].ToString();
                hdnpass.Text = dt.Rows[0]["password"].ToString();
                address.Text = dt.Rows[0]["address"].ToString();

            }
            else
            {
                Response.Redirect("edituser.aspx?error=Sorry, Something Went Wrong....!");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (pwd.Text != null || pwd.Text != "")
            {
                if (pwd.Text == cpwd.Text)
                {
                    funs f = new funs();
                    String pass = f.SHA_256_salted(pwd.Text, email.Text);
                    String cpass = f.SHA_256_salted(cpwd.Text, email.Text);
                    if (pass == cpass)
                    {
                        UserProps u = new UserProps();
                        u.U_id = u_id.Text;
                        u.U_name = name.Text;
                        u.U_cnic = cnic.Text;
                        u.U_cell = cell.Text;
                        u.U_email = email.Text;
                        u.U_password = pass;
                        u.U_address = address.Text;
                        u.U_access_level = access_level.SelectedValue.ToString();
                        UserBLL ubbb = new UserBLL();
                        if (ubbb.updateUserBLL(u))
                        {
                            Response.Redirect("edituser.aspx?success=User Updated Successfull");
                        }
                        else
                        {
                            Response.Redirect("edituser.aspx?error=Something Went Wrong....!");
                        }
                    }
                    else
                    {
                        Response.Redirect("edituser.aspx?error=Hash Doesn't Match.");
                    }
                }
                else
                {
                    Response.Redirect("edituser.aspx?error=Password Doesn't Match.");
                }
            }
            else
            {
                UserProps u = new UserProps();
                u.U_id = u_id.Text;
                u.U_name = name.Text;
                u.U_cnic = cnic.Text;
                u.U_cell = cell.Text;
                u.U_email = email.Text;
                u.U_password = hdnpass.Text;
                u.U_address = address.Text;
                u.U_access_level = access_level.SelectedValue.ToString();
                UserBLL ubbb = new UserBLL();
                if (ubbb.updateUserBLL(u))
                {
                    Response.Redirect("edituser.aspx?success=User Updated Successfull");
                }
                else
                {
                    Response.Redirect("edituser.aspx?error=Something Went Wrong....!");
                }
            }
        }
    }
}
