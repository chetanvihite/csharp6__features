using System;

using static System.Console;

namespace csharp6
{
    class StringInterpolation
    {
        public void WriteToConsole(string message, string priority)
        {
            WriteLine(string.Format($"Message: {message} and Priority: {priority}"));
        }
    }
}
