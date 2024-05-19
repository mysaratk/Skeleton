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

    protected Label GetIblStaffID()
    {
        return IblStaffID;
    }

    protected void BtnOK_Click(object sender, EventArgs e, Label IblStaffId)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the staff id
        AnStaff.StaffID = int.Parse(IblStaffId.Text);
        //store the staff id
        Session["Anstaff"] = AnStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }
}