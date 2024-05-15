using System;
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
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["Anstaff"];
        //display the staff id for this entry
        Response.Write(AnStaff.StaffID);
        // Get and display full name
        Response.Write(AnStaff.FullName);
        // Get and display isActive status
        Response.Write(AnStaff.Active);
        // Get and display date of birth
        Response.Write(AnStaff.DateOfBirth);
    }
}