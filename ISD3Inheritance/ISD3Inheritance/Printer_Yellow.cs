using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class Printer_Yellow : Printer
    {
        override public void Print(string value)
        {
            ConsoleColor c = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.BackgroundColor = c;
        }
    }
}
