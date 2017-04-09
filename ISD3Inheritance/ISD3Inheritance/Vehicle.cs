using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class Vehicle
    {
        double x;
        double y;
        double price;
        double speed;
        int year;
        public Vehicle(int x, int y, double price, double speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public void Info()
        {
            Console.WriteLine("x="+x);
            Console.WriteLine("y=" + y);
            Console.WriteLine("price=" + price);
            Console.WriteLine("speed=" + speed);
            Console.WriteLine("year=" + year);
        }
    }
}
