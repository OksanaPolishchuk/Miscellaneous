using System;

namespace Try
{
    public class Printer : MyConsole
    {
        private readonly IMyConsole _myConsole;

        public Printer(ConsoleColor console, IMyConsole myConsole)
        {
            _myConsole = myConsole;
        }

        public void Print(string value)
        {
            var dftForeColor = _myConsole.ForegroundColor;
            var dftBackColor = _myConsole.BackgroundColor;

            _myConsole.ForegroundColor = dftForeColor;
            _myConsole.BackgroundColor = dftBackColor;

            _myConsole.WriteLine(value);

            _myConsole.ForegroundColor = dftForeColor;
            _myConsole.BackgroundColor = dftBackColor;
        }
    }
}