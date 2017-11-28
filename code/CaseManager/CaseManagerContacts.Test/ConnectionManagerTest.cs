using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using caseman.datamodel;
using System.Data.Odbc;

namespace caseman.datamodel.test
{
    [TestFixture]
    class ConnectionManagerTest
    {

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

    }


}
