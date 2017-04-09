using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        virtual public void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно только в версии ПРО");
        }
        virtual public void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно только в версии ПРО");
        }

    }
}
