using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    

    


    
   
   
    
   


    class Program
    {
        static void Main(string[] args)
        {
            Printer_Yellow p1 = new Printer_Yellow();
            p1.Print("Hello from printer");


            //ClassRoom C = new ClassRoom(new ExcellentPupil(), new GoodPupil(), new BadPupil(), new BadPupil());
            // C.p[0].study();


            Plane plane = new Plane(10, 50, 1000, 28, 1995, 100, 2000);
            Ship ship = new Ship(10, 50, 1000, 28, 1995,20,"port-royal");
            Car car = new Car(10, 50, 1000, 28, 1995);

            Console.WriteLine("\n\n");
            Console.WriteLine("Plane info:");
            plane.Info();
            Console.WriteLine("\n\n");
            Console.WriteLine("Ship info:");
            ship.Info();
            Console.WriteLine("\n\n");
            Console.WriteLine("Car info:");
            car.Info();

            Console.WriteLine("\n\n");


            string key;
            Console.WriteLine("Enter a key:");
            key = Console.ReadLine();
            DocumentWorker worker;
            switch(key)
            {
                case ("pro"): worker = new ProDocumentWorker();
                    break;
                case ("exp"): worker = new ExpertDocumentWorker();
                    break;
                default: worker = new DocumentWorker();
                    break;
            }
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}
