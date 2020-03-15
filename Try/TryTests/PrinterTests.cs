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
    public class PrinterTests
    {
        private IMyConsole _printer;
        private Printer _target;

        [TestInitialize]
        public void Init()
        {
            _printer = Substitute.For<IMyConsole>();
            _target = new Printer(ConsoleColor.Blue,_printer);
        }

        [TestMethod()]
        public void PrintTest()
        {
           _target.Print("Color Blue");
           _printer.Received().WriteLine("Color Blue");
        }
    }
}