using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions4HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to open?");
            string answer = Console.ReadLine();
            AbstractHandler handler;
            
            switch (answer)
            {
                case "xml": handler = new XMLHandler();
                    break;
                case "doc": handler = new DOCHandler();
                    break;
                case "txt": handler = new TXTHandler();
                    break;
                default:
                    Console.WriteLine("Wrong format. Bye");
                    return;
            }
            handler.Create();
            handler.Open();
            handler.Change();
            handler.Save();

            Console.WriteLine("\n\n");
            Player player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            player.Record();
           
        }
    }
}
