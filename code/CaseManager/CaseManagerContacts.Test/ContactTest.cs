using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CaseManagerContacts;


namespace CaseManagerContacts.Test
{
    [TestFixture]
    public class ContactTest
    {

        [Test]
        public void CheckFirstName() {
            caseman.busmodel.contacts.Contact MyTestContact = null;
            MyTestContact = new caseman.busmodel.contacts.Contact();
            string testFirstName = "Tom";
            MyTestContact.FirstName = testFirstName;
            Assert.That(MyTestContact.FirstName == testFirstName);
        }

        [Test]
        public void CheckFirstNameTrim()
        {
            caseman.busmodel.contacts.Contact MyTestContact = null;
            MyTestContact = new caseman.busmodel.contacts.Contact();
            string testFirstName = "Tom ";
            MyTestContact.FirstName = testFirstName;
            Assert.That(MyTestContact.FirstName == testFirstName.Trim());
        }


        [Test]
        public void CheckLastName()
        {
            caseman.busmodel.contacts.Contact MyTestContact = null;
            MyTestContact = new caseman.busmodel.contacts.Contact();
            string testLastName = "Brown";
            MyTestContact.FirstName = testLastName;
            Assert.That(MyTestContact.FirstName == testLastName);
        }

    }
}
