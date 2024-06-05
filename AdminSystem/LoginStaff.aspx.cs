using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   

    protected void btnlogin_Click1(object sender, EventArgs e)
    {
        clsStaffUser AnUser = new clsStaffUser();
        string UserName = txtuname.Text;
        string Password = txtpass.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtuname.Text);
        Password = Convert.ToString(txtpass.Text);
        Found = AnUser.FindUser(UserName, Password);
        if (txtuname.Text == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtpass.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "login details are incorrect";
        }
    }
}