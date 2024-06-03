using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);

        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 2;
            TestItem.FullName = "Borislav";
            TestItem.Active = true;
            TestItem.DateOfBirth = DateTime.Now;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffID = 2;
            TestStaff.FullName = "Borislav";
            TestStaff.Active = true;
            TestStaff.DateOfBirth = DateTime.Now;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 2;
            TestItem.FullName = "Borislav";
            TestItem.Active = true;
            TestItem.DateOfBirth = DateTime.Now;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 2;
            TestItem.FullName = "Borislav";
            TestItem.Active = true;
            TestItem.DateOfBirth = DateTime.Now;
            AllStaff.ThisStaff= TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.FullName = "Borislav";
            TestItem.Active = true;
            TestItem.DateOfBirth = DateTime.Now;
            AllStaff.ThisStaff= TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.FullName = "Name";
            TestItem.Active = true;
            TestItem.DateOfBirth = DateTime.Now;
            AllStaff.ThisStaff= TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeleteMethod() 
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            int PrimaryKey = 0;
            TestItem.FullName = "Borislav";
            TestItem.Active = true;
            TestItem.DateOfBirth = DateTime.Now;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Foumd = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Foumd);
        }
        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredFullName = new clsStaffCollection(); ;
            FilteredFullName.ReportByFullName("");
            Assert.AreEqual(AllStaff.Count, FilteredFullName.Count);
        }
        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredFullName = new clsStaffCollection(); ;
            FilteredFullName.ReportByFullName("xx");
            Assert.AreEqual(0, FilteredFullName.Count);
        }
        [TestMethod]
        public void ReportByFullNameTestDataFoumd()
        {
            clsStaffCollection FilteredFullName = new clsStaffCollection();
            Boolean OK = true;
            FilteredFullName.ReportByFullName("yyy");
            if (FilteredFullName.Count == 3) 
            {
                if (FilteredFullName.StaffList[0].StaffID != 25) 
                {
                    OK = false;
                }
                if (FilteredFullName.StaffList[1].StaffID != 26) 
                {
                    OK = false; 
                }
            }
            else 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
            


    }
}
