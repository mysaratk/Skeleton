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
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false) 
        {
            if (StaffID != -1) 
            {
                DisplayStaff();
            }
        }

    }
    void DisplayStaff()
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ThisStaff.Find(StaffID);
        txtStaffId.Text = StaffList.ThisStaff.StaffID.ToString();
        txtFullName.Text = StaffList.ThisStaff.FullName;
        TxtDOB.Text = StaffList.ThisStaff.DateOfBirth.ToString();
        txtStaffId.Text = StaffList.ThisStaff.StaffID.ToString();
        ChkActive.Checked = StaffList.ThisStaff.Active;
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
        string StaffIDString = txtStaffId.Text;
        string FullName = txtFullName.Text;
        string DateOfBirthString = TxtDOB.Text;
        bool Active = ChkActive.Checked;
        string Error = "";

        // Assuming Find method accepts the parameters as string
        Error = AnStaff.Find(StaffIDString, FullName, DateOfBirthString, Active.ToString());

        if (Error == "")
        {
            // Convert StaffID from string to int
            int StaffID;
            if (int.TryParse(StaffIDString, out StaffID))
            {
                AnStaff.StaffID = StaffID;
            }
            else
            {
                lblError.Text = "Invalid StaffID.";
                return;
            }

            // Convert DateOfBirthString to DateTime
            DateTime DateOfBirth;
            if (DateTime.TryParse(DateOfBirthString, out DateOfBirth))
            {
                AnStaff.DateOfBirth = DateOfBirth;
            }
            else
            {
                lblError.Text = "Invalid Date of Birth.";
                return;
            }

            AnStaff.FullName = FullName;
            AnStaff.Active = Active;

            clsStaffCollection StaffList = new clsStaffCollection();

            if (StaffID == -1) // Assuming -1 means a new staff
            {
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffID);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
            }

            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnmain_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void BtnCncl_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}



