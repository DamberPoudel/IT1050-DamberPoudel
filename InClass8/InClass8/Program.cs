using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            // shape 2
            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("\n\n");
            // shape 3 
            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            // shape 4
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

