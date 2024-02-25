using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    abstract class AbstractClass
    {
        public int x, y;
        public AbstractClass(int a, int b)
        {
            x = a;
            y = b;
        }
        public abstract int Sum(int a,int b);
    }
    class DerABc:AbstractClass
    {
        public DerABc():base( 2,3 )
        {

        }
        public override int Sum(int a,int b)
        {
            return a + b;
        }

    }

}
