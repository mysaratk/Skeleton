using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsStaffCollection
    {
        void PopulateArray(clsDataConnection DB) 
        {
            //populates the array list based on the data in parameter DB
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff> ();
            while (Index < RecordCount) 
            {
                clsStaff AnStaff = new clsStaff (); 
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                mStaffList.Add (AnStaff);
                Index++;
            }
        }

        public clsStaffCollection()
        {
            {
                clsDataConnection DB = new clsDataConnection();
                DB.Execute("sproc_tblstaff_SelectAll");
                PopulateArray(DB);
            }
        }
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();   
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }   

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@Active", mThisStaff.Active);
            return DB.Execute("sproc_Staff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@Active", mThisStaff.Active);
            DB.Execute("sproc_tblstaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblstaff_Delete");
        }

        public void ReportByFullName(string FullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", FullName);
            DB.Execute("sproc_tblstaff_FilterByFullName");
            PopulateArray(DB);
        }
    } 
}