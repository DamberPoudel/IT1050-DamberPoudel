using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class MyMath
    {
        public int result;
        public double operand1;
        public double operand2;
        
        public int add(int x, int y)
        {
            operand1 = x;
            operand2 = y;
            result = x + y;

        }
        public int subtract(int x, int y)
        {
            return x - y;

        }
        public static int multiply(int x, int y)
        {
            return x * y;

        }
        public static int divide(int x, int y)
        {
            return x / y;
        }
    }
}
