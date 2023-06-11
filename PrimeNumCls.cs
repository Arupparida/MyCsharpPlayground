using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    /*

    Prime number is a number that is greater than 1 and divided by 1 or itself.
    In other words, prime numbers can't be divided by other numbers than itself or 1.
    For example 2, 3, 5, 7, 11, 13, 17, 19, 23.... are the prime numbers.
    In this C# program, we will take an input from the user and check whether 
    the number is prime or not.

    */


    internal class PrimeNumCls
    {
        public static void  Main()
        {
            //check if the given number is a prime number or not 
            int num = int.Parse(Console.ReadLine());
            bool flag = false;
            Console.WriteLine("Pls enter a number to check for prime number");
            for (int i = 2; i <= num; i++)

            {

                if (num % i == 0)
                {
                    flag = true;
                    Console.WriteLine("It's a non-Prime Number");
                    break;
                }
            
                    
                

                if (flag == false)
                {
                    Console.WriteLine("It's a Prime Number");
               
                }







            }
            /*
             * More problems related to Prime number  - src gfg
             * Find two distinct prime numbers with a given product
             * Print all prime numbers less than or equal to N
             * Recursive program for prime number
             * Find two prime numbers with a given sum
             * Find the highest occurring digit in prime numbers in a range
             * Prime Factorization using Sieve O(log n) for multiple queries
             * Program to print all prime factors of a given number
             * Least prime factor of numbers till n
             * Prime factors of LCM of array elements – GeeksforGeeks
             * Program for Goldbach’s Conjecture
             * Prime numbers and Fibonacci
             * Composite Number
             * 
                            
             */

        }
    }
    
}
