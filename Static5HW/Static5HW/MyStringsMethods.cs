using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static5HW
{
    static class MyStringsMethods
    {
        static public string Substing(string str, int first,int second)
        {
            string result ="";
            for(int i=0;i<=(first-second);i++)
            {
                result = result + str[first + i];
            }
            return result;
        }
        static public int IndexOf(string str, string target)
        {
            int n = -1;
            bool finded =false;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]==target[0])
                {
                    finded = true;
                    for(int j=1;j<target.Length;j++)
                    {
                        if(str[i+j]!=target[j])
                        {
                            finded = false;
                            break;
                        }
                    }
                    if (finded)
                        return n;
                }
            }
            return n;
        }
        static public string Replace(string str, string from, string to)
        {
            if (IndexOf(str, from) == -1) return str;
            string result = "";
            for(int i =0;i<str.Length;i++)
            {

                if(i< IndexOf(str,from) || i> IndexOf(str, from)+from.Length)
                {
                    result = result + str[i];
                }
                else
                {
                    result = result + to;
                    i = IndexOf(str, from) + from.Length;
                }
            }
            return result;
        }
    }
}
