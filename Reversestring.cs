using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{

    //You are given a string s. You need to reverse the string.
    class Reversestring
    {
        public static void Main()
        {
            
            //Reverse the string
            //Let's first reverse a num
            int num = 56;
            int rem;
          
            rem = num % 10;
            num = rem * 10 + num / 10;
            Console.WriteLine("Reversed num  : " + num);

            //Reverse a string 
            //It has something to do with index; swap index sequentially;
            string s = "Kite";
            int startindex;  int endindex;
            int n = s.Length;

            char[] StringArr = s.ToCharArray();
            Array.Reverse(StringArr);
            String reversedStr = new string(StringArr);
            Console.WriteLine("Original str : " + s);
            Console.WriteLine("Reversed Str : " + reversedStr);

            /*for(int i =0; i < n - 1; i++)
            {
                startindex = i; 
                endindex = n -1;
                s[startindex] = s[endindex];
              

            }*/



        }
        
    }
}
