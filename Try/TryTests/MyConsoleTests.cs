using Microsoft.VisualStudio.TestTools.UnitTesting;
using Try;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace TryTests
{
    [TestClass()]
    public class MyConsoleTests
    {
        IMyConsole _target;
        ConsoleColor _color;

        [TestInitialize]
        public void Init()
        {
            _target = new MyConsole();
            _color = new MyConsole().BackgroundColor;
        }

        [TestMethod()]
        public void MyConsoleTest()
        {
            _target.WriteLine("Blue");
        }

        [TestMethod()]
        public void WriteLineForegroundColorTest()
        {
            _color = ConsoleColor.Gray;
            var actualForegroundColor = _target.ForegroundColor;
            Assert.AreEqual(_color, actualForegroundColor);
        }

        [TestMethod()]
        public void BackgroundColorTest()
        {
            var actualBackgroundColor = _target.BackgroundColor;
            Assert.AreEqual(_color, actualBackgroundColor);
        }
    }
}