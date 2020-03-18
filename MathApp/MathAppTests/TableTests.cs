using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAppTests
{
    [TestClass()]
    public class TableTests
    {
        private Table _target;
        [TestInitialize]
        public void Init()
        {
            _target = new Table();
            var a = _target.Multiplication(2,1);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            var actual = _target.Multiplication(2,1);
            Assert.AreEqual("2 * 1 = 2", actual);
        }
    }
}