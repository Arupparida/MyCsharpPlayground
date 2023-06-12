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
}
