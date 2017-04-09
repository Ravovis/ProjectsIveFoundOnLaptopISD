using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD3Inheritance
{
    class Car: Vehicle
    {
        public Car(int x, int y, double price, double speed, int year): base(x,y,price,speed,year)
        {

        }
        public void Info()
        {
            base.Info();
        }
    }
}
