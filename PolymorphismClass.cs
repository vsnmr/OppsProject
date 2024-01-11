using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    class PolymorphismClass
    {
       public  int Addition (int a,int b)
        {
            return a + b;
        }
        public int Addition(int a,int b,double x)
        {
            double sd =(float) (a + b + x);
            return (int)sd;
        }

    }
}
