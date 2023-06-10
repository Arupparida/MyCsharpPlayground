using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    internal class SumOfDigit
    {
        //write a program to find the sum of first n odd integers 


        public static void Main()
        {
            //Method1
            Console.Write("Pls enter a value of n ");
           int n= Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                    sum = sum + i;                
            }
            Console.WriteLine(sum);

            

            Console.WriteLine("Pls enter n");
            int j= Convert.ToInt32(Console.ReadLine());
            int res=0;
            while(j > 0){
               if( j % 2 == 1)
                res = res + j;
                j--;
            }
            Console.WriteLine(sum); 
            
            

        }
    }
}
