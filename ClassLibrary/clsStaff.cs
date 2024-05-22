using System;

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
            //set the private data members to the test data value
            mStaffID = 1;
            mActive = true;
            mFullName = "Piotr";
            mDateOfBirth = Convert.ToDateTime("11/04/2000");
            //always return true
            return true;
        }
        public string Valid(string StaffID, string FullName, string DateOfBirth, string Active)
        {
            return "";
        }
    }
}