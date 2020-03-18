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
            string concat = "";

            for (int counter = 0; counter <= 10; counter++)
            {
                int result = 2 * counter;
                concat = string.Concat(concat, $"{2} * {counter} = {result}\n");
            }

            var actual = _target.Number();
            Assert.AreEqual(concat, actual);
        }
    }
}