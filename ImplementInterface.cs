using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    /// <summary>
    /// implementation interface and abstract class in one 
    /// interface
    /// </summary>
    interface ImplementInterface
    {
        void Draw();
    }
    /// <summary>
    /// abstract class
    /// </summary>
    abstract class ImplementAbstract
    {
        public abstract void DrawMethod();

    }
    class ImplementDerived :  ImplementAbstract, ImplementInterface
    {
        public override void DrawMethod()
        {
            Console.WriteLine("the circle is drawn");
        }
        public void Draw()
        {
            Console.WriteLine("the is created at there....");
        }
    }
}
