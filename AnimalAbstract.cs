using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    abstract class AnimalAbstract
    {
        public abstract void Animal();
        public void Hello()
        {
            Console.WriteLine("the hello is normal method");
        }
    }
    class DerivedAbstract:AnimalAbstract
    {
        public override void Animal()
        {
            Console.WriteLine("the abstract class Animal is called ");
        }
    }
}
