using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions4HW
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }
        public override void Change()
        {
            Console.WriteLine("Change TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    }
}
