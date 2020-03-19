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
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            var actual = _target.Multiplication(2, 1);
            Assert.AreEqual("2 * 1 = 2", actual);
        }

        [TestMethod()]
        public void NumberTest()
        {
            string expected = "2 * 0 = 0\n2 * 1 = 2\n2 * 2 = 4\n2 * 3 = 6\n2 * 4 = 8\n2 * 5 = 10\n2 * 6 = 12\n2 * 7 = 14\n2 * 8 = 16\n2 * 9 = 18\n2 * 10 = 20\n";
            var actual = _target.Number();
            Assert.AreEqual(expected, actual);
        }
    }
}