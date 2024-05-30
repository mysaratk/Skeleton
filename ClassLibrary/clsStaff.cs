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
            if (DB.Count == 1)
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
        public string Valid(string FullName, string DateOfBirth)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the FullName is blank
            if (FullName.Length == 0)
            {
                //record the error
                Error += "The full name may not be blank : ";
            }
            //if the FullName is greater than 6 characters
            if (FullName.Length > 50)
            {
                //record the error
                Error += "The full name must be less than 6 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the DateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateOfBirth);

                //check if the date is in the past
                if (DateTemp.AddYears(+199) < DateComp)
                {
                    //record the error
                    Error += "The date cannot be in the past : ";
                }

                //check if the date is in the future
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error += "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error if date conversion fails
                Error += "The date of birth is not a valid date : ";
            }

            //return any error messages
            return Error;
        }

    }
}




