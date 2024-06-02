using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsStaffCollection
    {
        public clsStaffCollection()
        {

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblstaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount) 
            { 
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                mStaffList.Add( AnStaff );
                Index++;
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
    }
}