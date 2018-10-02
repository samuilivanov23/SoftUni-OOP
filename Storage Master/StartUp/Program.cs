using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            GPU gpu = new GPU(10.8);
            Console.WriteLine($"{gpu.Price} + {gpu.Weight}");
        }
    }
}
