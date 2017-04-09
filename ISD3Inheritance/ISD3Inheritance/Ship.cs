using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class Ship:Vehicle
    {
        int passengers;
        string harbor;
        public Ship(int x, int y, double price, double speed, int year, int passengers, string harbor): base(x,y,price,speed,year)
        {
            this.passengers = passengers;
            this.harbor = harbor;
        }
        public void Info()
        {
            base.Info();
            Console.WriteLine("passengers=" + passengers);
            Console.WriteLine("harbor=" + harbor);
        }
    }
}
