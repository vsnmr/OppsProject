using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    class classInheritance
    {
        public void InheritanceMethod()
        {
            Console.WriteLine("\nThe base Inheritance Method is called");
        }
    }
    class InheritanceDerived:classInheritance
    {
        public void   InheritanceMethod2()
        {
            Console.WriteLine("\nthis is derived inheritance class called");
        }
    }


    
}
