using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    internal class Inheritance2
    {
        public static void main()
        {
            child1 nobj = new child1();
            nobj.newwer();
        }

    }

    class parent1
    {
        public int num1;
        public int num2;
        protected void meth1()
        {
            num1 = 3;
            num2 = 4;
        }
    }
    class parent2
    {
        public void meth2()
        {
            string str = "apple";
            string str2 = "phone";
        }
    }
    class child1 : parent1
    {
        private int num3;

        public void newwer()
        {
            //meth1();
            int sum = num1 + num2;
            Console.WriteLine("sum :" + sum);
        }

    }
}

    /*
    class A
    {
        public int a;
        public A()
        {
        
        a = 10;
        }
    }
    class B : A
    {
        public int b;
        public B()
        {
            b = 7;
        }
    }
    class C : A
    {
        public int c;
        public C()
        {
            c = 23;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hierarchical inheritance");
            B obj1 = new B();
            C obj2 = new C();
            Console.WriteLine("Using class B object (obj1)");
            Console.WriteLine("a = {0}", obj1.a);
            Console.WriteLine("b = {0}", obj1.b);
            Console.WriteLine("Using class C object (obj2)");
            Console.WriteLine("a = {0}", obj2.a);
            Console.WriteLine("c = {0}", obj2.c);
        }
    }
    

}
    */