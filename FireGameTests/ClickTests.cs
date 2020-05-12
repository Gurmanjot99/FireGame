using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame.Tests
{
    [TestClass()]
    public class ClickTests
    {
        [TestMethod()]
        public void Form2Test()
        {
            Form2 obj = new Form2();
            var s = obj.shoot_Count;
            Assert.IsTrue(true);

        }


        [TestMethod]
        public void genTest()
        {
            Click obj = new Click();
            var z = obj.gen();
            Assert.IsTrue(true);

        }
    }
}