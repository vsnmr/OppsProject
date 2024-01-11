using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
    interface MultipleInheritanceClassAdd
    {
        int Add(int x, int y);
    }
    interface MultipleInheritanceClassSub
    {
        int Sub(int a, int b);
    }
    class InhtitanceMultiple:MultipleInheritanceClassAdd,MultipleInheritanceClassSub
    {
        public int r,r2;
        public int Add(int x,int y)
        {
            return r = x + y;
        }
        public int Sub(int a,int b)
        {
            return r2 = a - b;
        }
    }

}
