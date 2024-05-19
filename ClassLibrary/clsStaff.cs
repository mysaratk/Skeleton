using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return StaffID;
            }
            set
            {
                //this line of code allows data into the property
                StaffId = value;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public object FullName { get; set; }
        public object Active { get; set; }
        //private data member for the staff id property
        private Int32 StaffId;

        public bool Find(int staffID)
        {
            //set the private data members to the test data value
            StaffId = 21;
            //always return true
            return true;
        }
    }
}