using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static5HW
{
    static class MyArraySort
    {
        public static void sort(int[] arr,bool ascend)
        {
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(ascend && arr[i]>arr[j] || !ascend && arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    } 
                }
            }
        }
    }
}
