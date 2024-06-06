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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        int CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = AnCustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AnCustomer.FirstName;
            txtLastName.Text = AnCustomer.LastName;
            txtEmail.Text = AnCustomer.Email;
            txtPhoneNumber.Text = AnCustomer.PhoneNumber.ToString();
            txtDateAdded.Text = AnCustomer.DateAdded.ToString();
            txtLogin.Text = AnCustomer.Login;
            txtPassword.Text = AnCustomer.Password;
        }
    }
}