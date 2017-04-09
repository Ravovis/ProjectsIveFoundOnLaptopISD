using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions4HW
{
    class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Create DOC");
        }
        public override void Change()
        {
            Console.WriteLine("Change DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Save DOC");
        }
    }
}
