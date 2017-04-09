using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class Plane: Vehicle
    {
        int passengers;
        double z;
        public Plane(int x, int y, double price, double speed, int year, int passengers, double z): base(x,y,price,speed,year)
        {
            this.passengers = passengers;
            this.z = z;
        }
        public void Info()
        {
            base.Info();
            Console.WriteLine("passengers=" + passengers);
            Console.WriteLine("z=" + z);
        }
    }
}
