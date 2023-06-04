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
            /*
            //Reverse the string
            //Let's first reverse a num
            int num = 5678;
            int rem;
          
            rem = num % 10;
            num = rem * 10 + num / 10;
            Console.WriteLine("Reversed num  : " + num);

            //Reverse a string 

            //It has something to do with index; swap index sequentially;
            string s = "Kite";
            int startindex;  int endindex;
            int n = s.Length;

            //First easy method using Array.Reverse Funtion.

            char[] StringArr = s.ToCharArray();
            Array.Reverse(StringArr);
            String reversedStr = new string(StringArr);
            Console.WriteLine("Original str : " + s);
            Console.WriteLine("Reversed Str : " + reversedStr);

            //Also discovered ReverseString is also a type.Maynot relevant in this context,
            */

            //Second Method using recursion
            int start = 0;
            int end = 5;

            int temp;

            int[] SArr = {1,2,3,4,5,6};

            while (start < end)
            {
                temp = SArr[start];
                SArr[start] = SArr[end];
                SArr[end] = temp;
                start++;
                end--;

            }

            for(int i = 0; i < 6; i++)
            {
                Console.Write(SArr[i]+ " ");
                
            }


            //Another mehod to do reverse a string

            string strr = "transpose";
            string reverse = " ";
            int length = strr.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + strr[length];
                length--;
            }
            Console.Write(reverse);




            
              

           



        }
        
    }
}
