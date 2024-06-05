﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the first name for this entry
        Response.Write(AnCustomer.FirstName);
        //display the last name for this entry
        Response.Write(AnCustomer.LastName);
        //display the email for this entry
        Response.Write(AnCustomer.Email);
        //display the phone number for this entry
        Response.Write(AnCustomer.PhoneNumber);
        //display the login for this entry
        Response.Write(AnCustomer.Login);
        //display the password for this entry
        Response.Write(AnCustomer.Password);
        //display the date added for this entry
        Response.Write(AnCustomer.DateAdded);
        //display the customer id for this entry
        Response.Write(AnCustomer.CustomerId);
    }
}