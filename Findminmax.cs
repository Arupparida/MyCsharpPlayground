using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    class Findminmax
    {
        // C# code for the approach

		static void Main()
		{
			// Input array
			int[] arr = { 1, 423, 6, 46, 34, 23, 13, 53, 4 };
			int n = arr.Length;
			// Sort the array
			Array.Sort(arr);

			// after sorting the value at 0th position will be
			// minimum and nth position will be maximum
			Console.WriteLine("min-" + arr[0] + " max-"
							+ arr[n - 1]);
		}
	}



}

