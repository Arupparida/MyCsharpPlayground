using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyCsharpPlayground
{
    class PeakElement
    {

        static  int peakElement(int[] arr, int n)
        {
            int peak = 0;
            if (n == 1)
                return 0;
            for (int i = 1; i < n; i++)
            {
                //int[] arr1 = new int[] { 1, 2, 6, 7 };
                if (arr[i] > arr[i - 1])
                {
                    peak = i;
                }
            }
            return peak;
            //Console.WriteLine(peak);


        }
        public static void Main()
        {
            int[] arr1 = new int[] { 1, 2, 6, 7, 9,8,10,5};
            int n = arr1.Length;
            Console.Write("Index of a peak point is " +  peakElement(arr1, n));
            //PeakElement nobj = new PeakElement();
            //nobj.peakElement(arr1, n);

        }


    }
}


    

