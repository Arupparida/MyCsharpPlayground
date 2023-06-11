using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    internal class Palindromecls
    {   

        /*
         * Check if a given string is a palindrome. 
                 
         * 
         */

        //Invastigate code - recursive method
        /* 
         
         
        bool solution(string inputString)
        {
            int len = inputString.Length;
            for (int i = 0; i < inputString.Length / 2 - 1; i++)
            {
                if (inputString[i] == inputString[len - 1])
                    Console.WriteLine(inputString[len - 1]);
                {
                    i++;
                    len--;
                }


            }
            return true;
            Console.WriteLine("false");



        }

        */




        public static void Main()
        {
            //A palindrome number is a number that is same after reverse.
            //For example 121, 34543, 343, 131, 48984 are the palindrome numbers.
            //Write a program to check if number is a palindrome.
            int reverse = 0;
            int reminder = 0;
           
            Console.Write("Pls enter a number : ");
            int number =  int.Parse(Console.ReadLine());
            int temp = number;
            //new thing learned here , just comment out temp in above step and use number variable 
            //to compare to the reverse number. The result is wrong.

            //int number = 34543;
            //swap the number and check if they are same 
            while (number > 0)
            {
                reminder = number % 10;
                reverse = reverse * 10 + reminder;
                number = number / 10;
                
            }
           
            Console.WriteLine("reverse is " + reverse); 
            if (reverse == temp)
            {
                Console.WriteLine("It is a Palindrome");

            }
            else
            {
                Console.WriteLine("nil");
            }
                
            

            Palindromecls nobj = new Palindromecls();
            nobj.solution("abac");
            Console.WriteLine(nobj.solution("abac"));
            


        }

    }
}
