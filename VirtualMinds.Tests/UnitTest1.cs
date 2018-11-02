using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualMinds.Services;

namespace VirtualMinds.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetUser()
        {
            var service = new UserServices();
            var result = service.GetUser();

            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void TestInsertUser()
        {
            try
            {
                var service = new UserServices();
                var usu = new VirtualMinds.Models.Usuario();
                usu.idUser = 1;
            
                service.Save(usu);
                Assert.IsTrue(true);
            }
            catch (Exception ex )
            {
                Assert.IsTrue(false, ex.Message);
            }
        }
    }
}
