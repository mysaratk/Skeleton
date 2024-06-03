using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();

        }
    }
    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "FullName";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEDIT_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffID = Convert.ToInt32
                (lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else 
        {
            lblError.Text = " Please select a recored to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectedIndex != -1 ) 
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else 
        {
            lblError.Text = " Please select a recored from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection AnStaff = new clsStaffCollection();
        AnStaff.ReportByFullName(txtFN.Text);
        lstStaffList.DataSource = AnStaff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "FullName";
        lstStaffList.DataBind();
    }

    protected void btnCLEAR_Click(object sender, EventArgs e)
    {
        clsStaffCollection AnStaff = new clsStaffCollection ();
        AnStaff.ReportByFullName("");
        txtFN.Text = "";
        lstStaffList.DataSource= AnStaff.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "FullName";
        lstStaffList.DataBind ();
    }
}