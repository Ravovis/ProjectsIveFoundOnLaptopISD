using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static5HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine(Calculator.add(5,6));

            Console.WriteLine("\n\n");
            Console.WriteLine("Sorted array");
            int[] array = new int[] { 1, 8, 4, 2, 0, 5, 1 };
            MyArraySort.sort(array,false);
            for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i]+"\t");
                
            }
            MyArraySort.sort(array, true);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");

            }

            Console.WriteLine("\n\n");


        }
    }
}
