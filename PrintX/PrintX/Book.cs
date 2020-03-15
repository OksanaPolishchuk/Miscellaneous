using System;

namespace PrintX
{
    public class Book
    {
        private readonly IPrint _print;
        private readonly string _content;

        public Book(IPrint print, string content)
        {
            _print = print;
            _content = content;
        }

        public void Show()
        {
           _print.WriteLine(_content);
        }
    }
}