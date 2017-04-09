using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class ExpertDocumentWorker: ProDocumentWorker
    {
        override public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
