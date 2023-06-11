using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    internal class Factorialcls
    {
        public static void Main()
        {
            //Facturial of a Number 

            Console.Write("Pls a enter for Factorial : ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1 , result =0;
            /*while (num > 0) 
            {
                result =  num * (num - 1); // 5*4 4*3
                fact = fact * result;
                num--;
            }*/
            //for(int i = 1; i <= fact; i++) 
            for(int i = num; i >=1; i--)
            {
                fact = fact * i;
            
            }
                Console.WriteLine("Factorial of number  :" + fact);

        }
    }
}
