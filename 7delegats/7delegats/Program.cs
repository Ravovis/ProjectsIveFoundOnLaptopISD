using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7delegats
{
    class Program
    {
        delegate int srArifm(int a, int b, int c);

        delegate string ArifmOperation(double a, double b);

        delegate int innerFunction();

        static Random r = new Random();

        public static int randomizer()
        {
           
            return r.Next(100);
        }
       
       // MulticastDelegate 

        static void Main(string[] args)
        {
            //Делегат не выходит внести, но и не выходит анонимную функцию вынести
            //srArifm anon1 = delegate (int a, int b, int c)
            //{
            //    return (a + b + c) / 3;
            //};
            //Console.WriteLine(anon1(5, 6, 7)); 

            //ArifmOperation add = (a,b) => "" + (a + b);
            //ArifmOperation substraction = (a, b) => "" + (a - b);
            //ArifmOperation multiply = (a, b) => ""+ (a * b);
            //ArifmOperation divide = (a, b) => b != 0 ? ("" + (a / b)) : "На ноль делить нельзя";
            //Console.WriteLine("What you want to do - add,substract,multiply or divide?");
            //string answer2 = Console.ReadLine();
            //Console.WriteLine("Enter a and b");
            //int a2 = int.Parse(Console.ReadLine());
            //int b2 = int.Parse(Console.ReadLine());
            //switch(answer2)
            //{
            //    case "add":
            //        Console.WriteLine(add(a2,b2));
            //        break;
            //    case "substract":
            //        Console.WriteLine(substraction(a2, b2));
            //        break;
            //    case "multiply":
            //        Console.WriteLine(multiply(a2, b2));
            //        break;
            //    case "divide":
            //        Console.WriteLine(divide(a2, b2));
            //        break;
            //}


            innerFunction arr = new innerFunction(randomizer) + new innerFunction(randomizer)+ new innerFunction(randomizer);

            Delegate[] myarr = arr.GetInvocationList();

            int acumulator = 0;
            for(int i = 0; i<myarr.Length; i++)
            {
               
                int temp = (int)(myarr[i].DynamicInvoke());
                Console.WriteLine(temp);
                acumulator += temp;
            }
            Console.WriteLine("Среднее: "+(acumulator/ myarr.Length));

        }
    }
}
