using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boots xILENC = new Boots();
            xILENC.Zap();
            Console.WriteLine("#1 TEST");
            xILENC.GetInfo();

            Console.WriteLine();
            xILENC.Zap();
            Console.WriteLine("#2 TEST");
            xILENC.GetInfo();

            Console.WriteLine();
            xILENC.Zap();
            Console.WriteLine("#3 TEST");
            xILENC.GetInfo();

            Console.ReadKey(true);
        }
    }
}
