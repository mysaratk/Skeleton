using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data.SqlClient;
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




    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = AnStaff.Find(StaffId);
        if (Found == true)
        {
            txtFullName.Text = AnStaff.FullName;
            TxtDOB.Text = AnStaff.DateOfBirth.ToString();
            ChkActive.Checked = AnStaff.Active;

        }

    }

    protected void BtnOk_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        string StaffID = txtStaffId.Text;
        string FullName = txtFullName.Text;
        string DateOfBirth = TxtDOB.Text;
        string Active = ChkActive.Text;
        string Error = "";
        Error = AnStaff.Find(StaffID, FullName, DateOfBirth, Active);
        if (Error == "")
        {
            AnStaff.StaffID = int.Parse(IblStaffID.Text);
            AnStaff.FullName = txtFullName.Text;
            AnStaff.DateOfBirth = DateTime.Now;
            AnStaff.Active = ChkActive.Checked;
            Session["AnStaff"] = AnStaff;
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            
        }
        }
    }

   

  