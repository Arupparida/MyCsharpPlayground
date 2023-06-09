using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    internal class CenturyFromYear
    {

        //Write a C# program to get the century of a year.
        int solution(int year)
        {
            int result = 0;
            if (year % 100 == 0)
                result = year / 100;
            else if (year % 100 != 0)
                result = year / 100 + 1;

            return result;

        }
        public static void Main()
        {
            CenturyFromYear nobj = new CenturyFromYear();
            Console.WriteLine("Pls enter a Year to predict it's century");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nobj.solution(year));

            
        }
    }
}
