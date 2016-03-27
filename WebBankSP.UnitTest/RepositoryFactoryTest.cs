using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebBankSP;

namespace WebBankSP.UnitTest
{
    [TestClass()]
    public class RepositoryFactoryTest
    {
        [TestMethod()]
        public void GetIAuthenticationTest()
        {
            IAuthentication expected = new Authentication(null, null);
            IAuthentication actual;

            actual = RepositoryFactory.GetIAuthentication();

            Assert.AreEqual(expected.GetType(), actual.GetType());

       }
    }
}
