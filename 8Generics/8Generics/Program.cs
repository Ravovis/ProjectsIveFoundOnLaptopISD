using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Generics
{
    class Program
    {

        class newClass1
        {
            public int k = 5;
        }
        static class MyClass<T> where T : new()
        {
            public static T FactoryMethod()
            {
                return new T();
            }
        }

        class MyList<T> where T : struct //аналогично arrayList
        {
            T[] arr;
             int length;

            public MyList()
            {
                arr = null;
                length = 0;
            }
            public void Add(T element)
            {
                if(length==0)
                {
                    arr = new T[1];
                    
                }
                else
                    Array.Resize(ref arr, arr.Length + 1);
                arr[length] = element;
                this.length++;
            }
           
            public int Length
            {
                get
                {
                    return length;
                }
            }
            public T this[int i]
            {
                get
                {
                    return arr[i];
                }
                set
                {
                    arr[i] = value;
                }
            }
        }

        class MyDictionary<TKey, TValue> //Dictionary ж то же самое
        {
            struct Node
            {
                public TKey key;
                public TValue value;
            }
            Node[] arr;
            int length;
            public MyDictionary()
            {
                arr = null;
                length = 0;
            }
            public void Add(TKey key, TValue element)
            {
                if (length == 0)
                    arr = new Node[1];
                else
                    Array.Resize(ref arr, arr.Length + 1);
                Node temp;  temp.key = key; temp.value = element;
                arr[length] = temp;
                this.length++;
            }
            public int Length
            {
                get
                {
                    return length;
                }
            }
            public TValue this[TKey i]
            {
                get
                {
                    int j;
                    for(j=0;j<length;j++)
                    {
                        if (arr[j].key.Equals(i))
                            break;
                    }
                    return arr[j].value;
                        

                }
                set
                {
                    int j;
                    for (j = 0; j < length; j++)
                    {
                        if (arr[j].key.Equals(i))
                            break;
                    }
                    arr[j].value = value;

                }
            }

        }


        //public static T[] GetArray<T>(this MyList<T> list)
        //{
        //}
        
        class ClassColection<T> where T: class
        {
            T[] arr;
            int length;

            public ClassColection()
            {
                arr = null;
                length = 0;
            }
            public void Add(T element)
            {
                if (length == 0)
                {
                    arr = new T[1];

                }
                else
                    Array.Resize(ref arr, arr.Length + 1);
                arr[length] = element;
                this.length++;
            }

            public int Length
            {
                get
                {
                    return length;
                }
            }
            public T this[int i]
            {
                get
                {
                    return arr[i];
                }
                set
                {
                    arr[i] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            newClass1 s = MyClass<newClass1>.FactoryMethod();

            MyList<int> lst = new MyList<int>() ;
           
            for (int i = 0; i < 5; i++)
                lst.Add(i);
            Console.WriteLine(lst[3]);

            MyDictionary<string, int> dictionary = new MyDictionary<string,int>();
            dictionary.Add("A",3);
            dictionary.Add("B", 54);
            dictionary.Add("C", 1);
            dictionary.Add("D", 2);
            dictionary.Add("E", 76);

            Console.WriteLine(dictionary["E"]);





        }
    }
}
