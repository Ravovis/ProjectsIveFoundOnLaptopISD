using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions4HW
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML");
        }
        public override void Create()
        {
            Console.WriteLine("Create XML");
        }
        public override void Change()
        {
            Console.WriteLine("Change XML");
        }
        public override void Save()
        {
            Console.WriteLine("Save XML");
        }
    }
}
