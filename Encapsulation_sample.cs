using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCsharpPlayground
{
    public class Encapsulation_sample
    {
        private string StudentName;
        private int StudentAge;

        //private variables declared and these can only be accessed through public methods of a class


        //using acceser to get and set the value of encapsulated strings StudentName
        public string Name
        {
            get { return StudentName; }
            set { StudentName = value; }

        }
        //using accessors to get and set the value of StudentAge
        public int Age
        {
            get { return StudentAge; }
            set { StudentAge = value; }
        }


    }

    public class encapsulationclass_sample
    {
        //private string Name;

        public static void Main()
        {
            encapsulationclass_sample obj =  new encapsulationclass_sample();
            Encapsulation_sample nobj =  new Encapsulation_sample();
            nobj.Name = "Ankita";
            nobj.Age = 21;

            Console.WriteLine(nobj.Name);   
            Console.WriteLine(nobj.Age);    

        }

    }
}
