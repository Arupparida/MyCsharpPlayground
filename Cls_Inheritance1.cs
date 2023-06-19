using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    class Cls_Inheritance1
    {

        //Practicing inheritance and types of Inheritance 
        /*
         * Inheritance : It is carrying forward the properties or traits of a class to another class
         * Code reuseability is the key focus during inheritance 
         * Using Inheritance one or more classes can be derived from an existing class
         * The existing class is called parent/base class and the inherited class is derived/inherited class
         * Types of inheritance 
         * 1. single 
         * 2. hierarchical
         * 3. Multi-level
         * 4. Multiple(using Interface)
         * A Quick go through can be done from  : https://www.c-sharpcorner.com/UploadFile/0c1bb2/types-of-inheritance-in-C-Sharp/
         * 
     
         */

        public static void Main()
        {
            debitinfo nobj = new debitinfo();
            Console.WriteLine(nobj.Debit());
            Console.WriteLine(nobj.Credits());
            //nobj.Debit();



            child1 obj = new child1();
            obj.newwer();
        }
    }
    }

        public class AccountCreditInfo //base class
    { 
        public string Credits()
        {
            return "Balance is credited";

        }
    }

    public class debitinfo : AccountCreditInfo  //derived class
    {
        public string Debit()
        
        {
            Credits();
            Console.WriteLine(Credits());
            return "Balance is debited ";
          
        }  

        
    }

    internal class Inheritance2
    {
        public static void main()
        {
            

    }

    class parent1
    {
        public int num1;
        public int num2;
        public void meth1()
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
        int sum;
        public void newwer()
        {
            meth1();
            sum = num1 + num2;
            
            //return sum;
            Console.WriteLine("sum ybhdb :" + sum);
            Console.WriteLine("num1" + num1);
        }

    }
}




