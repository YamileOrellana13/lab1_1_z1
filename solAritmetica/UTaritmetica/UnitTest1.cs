using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTaritmetica
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            const int numa = 1;
            const int numb = 2;
            const int resp = 3;
            // Act

            using (srvAritmetica.WSaritmeticaClient cliente = new srvAritmetica.WSaritmeticaClient())
            {
                var rsp = cliente.Sumar(numa, numb);

            //assert
                Assert.AreEqual(resp, rsp.respuesta);
            }
        }
    }
}
