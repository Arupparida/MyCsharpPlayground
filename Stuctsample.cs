using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    public class Stuctsample
    {
        static void Main(string[] args)
        {
            point point1;
            point1.x = 10;
            point1.y = 20;

            Console.WriteLine($"point1 : x = {point1.x}, y = {point1.y}");
    }
}

    public struct point
    {
        public int x;
        public int y;

    }

    
}
