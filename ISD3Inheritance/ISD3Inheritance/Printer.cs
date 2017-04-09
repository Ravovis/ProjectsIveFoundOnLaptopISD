using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class Printer
    {
        virtual public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
