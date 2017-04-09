using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class ProDocumentWorker: DocumentWorker
    {
        
        override public void EditDocument()
        {
            Console.WriteLine("Документ Отредактирован");
        }
        override public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в режиме Эксперт");
        }
    }
}
