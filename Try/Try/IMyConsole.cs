using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    public interface IMyConsole
    {
        void WriteLine(string value);
        ConsoleColor ForegroundColor { get; set; }
        ConsoleColor  BackgroundColor { get; set; }
    }
}
