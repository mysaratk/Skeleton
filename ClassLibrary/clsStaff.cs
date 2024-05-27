using System;
using System.Dynamic;

namespace ClassLibrary
{
    public class clsStaff
    {
        private string mFullName;
        private DateTime mDateOfBirth; // or DateTime if it represents a date
        private bool mActive;
        private int mStaffID; // or string if StaffID is a string
        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }
        public String FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mFullName;
            }
            set
            {
                //this line of code allows data into the property
                mFullName = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows data into the property
                mDateOfBirth = value;
            }
        }
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        public bool Find(int staffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("dbo.tblstaff_FilterBystaffId");
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[1][3]);
                mFullName = Convert.ToString(DB.DataTable.Rows[1]["Piotr"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[1]["11/04/2000"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[1]["true"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
