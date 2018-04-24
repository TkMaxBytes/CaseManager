using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using caseman.datamodel;
using System.Data.Odbc;
using caseman.busmodel.contacts;

namespace caseman.datamodel.test
{
    [TestFixture]
    public class ConnectionManagerTest
    {
        [Test]
        public void DsnEmpty()
        {
            string strMess = null;
            OdbcConnection objCon = null;
            try
            {
                objCon = ConnectionManager.GetDatabaseConnection("");
                strMess = String.Format("Expected exception '{1}' ", "ArgumentException");
                Assert.Fail(strMess);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
            catch (Exception ex)
            {
                strMess = String.Format("Expected exception '{1}' Actual '{2}'", "ArgumentException", ex.GetType().Name);
                Assert.Fail(strMess);
            }

        }

    }//Class ConnectionManager


    [TestFixture]
    public class ContactTest
    {

        [Test]
        public void CheckTitle()
        {
            Contact MyTestContact = null;
            MyTestContact = new Contact();
            string testTitle = "Mrs";
            MyTestContact.Title = testTitle;
            Assert.That(MyTestContact.Title == testTitle);
        }

        [Test]
        public void CheckTitleTrim()
        {
            Contact MyTestContact = null;
            MyTestContact = new Contact();
            string testTitle = " Mrs ";
            MyTestContact.Title = testTitle;
            Assert.That(MyTestContact.Title == testTitle.Trim());
        }

        [Test]
        public void CheckFirstName()
        {
            Contact MyTestContact = null;
            MyTestContact = new Contact();
            string testFirstName = "Tom";
            MyTestContact.FirstName = testFirstName;
            Assert.That(MyTestContact.FirstName == testFirstName);
        }

        [Test]
        public void CheckFirstNameTrim()
        {
            Contact MyTestContact = null;
            MyTestContact = new Contact();
            string testFirstName = "Abigail       ";
            MyTestContact.FirstName = testFirstName;
            Assert.That(MyTestContact.FirstName == testFirstName.Trim());
        }

        //REQ044 - The LastName should have no trailing spaces
        [Test]
        public void CheckLastName()
        {
            Contact MyTestContact = null;
            MyTestContact = new Contact();
            string testLastName = "Brown";
            MyTestContact.LastName = testLastName;
            Assert.That(MyTestContact.LastName == testLastName);
        }

        [Test]
        public void CheckLastNameTrim()
        {
            Contact MyTestContact = null;
            MyTestContact = new Contact();
            string testLastName = "Brown ";
            MyTestContact.LastName = testLastName;
            Assert.That(MyTestContact.LastName == testLastName.Trim());
        }


    }

}
