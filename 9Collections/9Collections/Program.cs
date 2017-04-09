using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Collections
{

    static class Task1
    {
        public static void Execute()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            IEnumerable<int> res = getnewcollection(arr);
            for(int i=0; i<res.Count();i++ )
                Console.WriteLine(res.ElementAt(i));
            
        }

        
        static public IEnumerable<int> getnewcollection(int[] arr)
        {
            for(int i=0; i<arr.Length;i=i+2)
            {
                yield return arr[i];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task1.Execute();
            //Task2.Execute // В прошлой теме уже было такое задание
            //Task3.Execute // В прошлой теме уже было такое задание
            //Task4.Execute // В прошлой теме уже было такое задание
        }
    }
}
