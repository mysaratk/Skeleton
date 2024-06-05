using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {   
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the first name
        AnCustomer.FirstName = txtFirstName.Text;
        //capture the last name
        AnCustomer.LastName = txtLastName.Text;
        //capture the email
        AnCustomer.Email = txtEmail.Text;
        //capture the phone number
        AnCustomer.PhoneNumber = Convert.ToInt16(txtPhoneNumber.Text);
        //capture the login
        AnCustomer.Login = txtLogin.Text;
        //capture the password
        AnCustomer.Password = txtPassword.Text;
        //capture the date added
        AnCustomer.DateAdded = Convert.ToDateTime(DateTime.Now);
        //capture the customer id
        AnCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //store the customer details in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
}