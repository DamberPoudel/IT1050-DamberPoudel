using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = MyMath.Multiply(2, 2);
            { Console.WriteLine(product); }

            int quotient = MyMath.Divide(10, 2);
            { Console.WriteLine(quotient); }

            MyMath mathobj1 = new MyMath();
            int sum = mathobj1.Add(1, 2);
            { Console.WriteLine(sum);}

            MyMath mathobj2 = new MyMath();
            int difference = mathobj2.subtract(1, 2);
            { Console.WriteLine(difference); }

        }
    }
}
