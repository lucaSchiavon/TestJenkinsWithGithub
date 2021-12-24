using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestJenkinsEFPipelines.Test
{
    [TestClass]
    public class TestJenkinsEFPipelinesTest
    {
        [TestMethod]
        public void HelloWorld_GeneraUnOggettoJson_MiAspettoUnOggettoValorizzatoInUnCertoModo()
        {
            //arrange
            Manager manager = new Manager();
            //act
            string s=manager.HelloWorld();
            //assert
            Assert.IsTrue(s.Contains("Hello world"));
        }
    }
}
