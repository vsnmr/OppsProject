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
    interface SumTwoNumbers
    {
        void Sum();
    }
    class InhtitanceMultiple:MultipleInheritanceClassAdd,MultipleInheritanceClassSub, SumTwoNumbers
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

        public void Sum()
        {
            int x = 23;
            int y = 34;
           int sumResult = x + y;
            Console.WriteLine("The sum of two numbers is "+sumResult);
        }
    }

}
