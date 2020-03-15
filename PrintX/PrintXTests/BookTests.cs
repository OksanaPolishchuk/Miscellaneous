using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using PrintX;

namespace PrintXTests
{
    [TestClass()]
    public class BookTests
    {
        private Book _target;
        private IPrint _print;

        [TestInitialize]
        public void Init()
        {
            _print = Substitute.For<IPrint>();
            //var print = new Print();
            var content = "content";
            _target = new Book(_print, content);
        }

        [TestMethod()]
        public void ShowTest()
        {
            _target.Show();
            _print.Received().WriteLine("content");
        }
    }
}