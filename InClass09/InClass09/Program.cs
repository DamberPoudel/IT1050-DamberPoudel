using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            calling static methods from within program.cs
            int sum = AddNumbers(5, 6, 7);
            Console.WriteLine(sum);
            */

            //static method call to multiply
            int product = MyMath.Multiply(7, 3);
            Console.WriteLine("Product:" + product);

            MyMath mathobj1 = new MyMath();
            int sum = mathobj1.Add(7, 3);


        }
        

        /*
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        static int AddNumbers(int a, int b, int c)
        {
            return a + b + c;

        }

    }
}
