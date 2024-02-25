using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    class MethodoverRidingBase
    {
        public void Greetings()
        {
            Console.WriteLine("Hello Method override Base class Method iscalled");
        }
    }
    class MethodDerived:MethodoverRidingBase
    {
        public  void Greetings()
        {
            Console.WriteLine("derived class is called");
        }

        }
}
