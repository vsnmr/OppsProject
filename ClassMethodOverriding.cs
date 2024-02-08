using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    class ClassMethodOverriding
    {
        public virtual void Flower()
        {
            Console.WriteLine("The Color of Flower is Red");
        }
    }
    class DerivedMethodoverriding : ClassMethodOverriding
    {
        public  override void Flower()
        {
            Console.WriteLine("\nThe Color of Flower Yellow");
        }
    }
    //class overidingAnimal
    //{
    //    public virtual string Sound { get }
    //}
}
