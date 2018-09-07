using System;

namespace ConsoleBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            BufferdConsole bufferdConsole = new BufferdConsole();
            try
            {
                bufferdConsole.Write(new string('a', 49));
                bufferdConsole.Write(new string('c', 51));
            }
            finally
            {
                ((IDisposable)bufferdConsole).Dispose();
            }
        }
    }
}
