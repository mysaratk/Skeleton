using System;
using System.Dynamic;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffID;
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
        private string mFullName;
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
        private DateTime mDateOfBirth;
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
        private bool mActive;
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
        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("tblstaff_FilterBystaffId");
            if(DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
            else 
            {
                return false;
            }

        }
       
public string Find(string staffID, string fullName, string dateOfBirth, string active)
        {
            throw new NotImplementedException();
        }

        public string Valid(string FullName, string dateOfBirth)
        {
            string Error = "";
            if (FullName.Length == 0) 
            {
                Error = Error + " The Full Name may not be blank";
            }
            return Error;
        }
    }
}
