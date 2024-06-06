using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private int mCustomerId;
        //private data member for the first name property
        private string mFirstName;
        //private data member for the last name property
        private string mLastName;
        //private data member for the email property
        private string mEmail;
        //private data member for the phone number property
        private short mPhoneNumber;
        //private data member for the login property
        private string mLogin;
        //private data member for the password property
        private string mPassword;
        //private data member for the date added property
        private DateTime mDateAdded;

        //firstName public property
        public string FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }

            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }

        //lastName public property
        public string LastName 
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }

            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }

        //email public property
        public string Email 
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }

            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }

        //phoneNumber public property
        public short PhoneNumber 
        {
            get
            {
                //this line of code sends data out of the property
                return mPhoneNumber;
            }

            set
            {
                //this line of code allows data into the property
                mPhoneNumber = value;
            }
        }

        //login public property
        public string Login 
        {
            get
            {
                //this line of code sends data out of the property
                return mLogin;
            }

            set
            {
                //this line of code allows data into the property
                mLogin = value;
            }
        }

        //password public property
        public string Password
        {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }

            set
            {
                //this line of code allows data into the property
                mPassword = value;
            }
        }

        //dateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }

            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //customerId public property
        public int CustomerId 
        { 
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }

            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        //******** FIND METHOD *************
        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblUserAccount_FilterByCustomerId");
            //if one record is found (there should be either  one or zero)
            if (DB.Count == 1 ) 
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhoneNumber = Convert.ToInt16(DB.DataTable.Rows[0]["PhoneNumber"]); ;
                mLogin = Convert.ToString(DB.DataTable.Rows[0]["Login"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem 
                return false;
            }
        }
    }
} 