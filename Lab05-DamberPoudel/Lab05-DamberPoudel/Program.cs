using System;

namespace Lab05_DamberPoudel
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedlimit = 35;
            int speed = 42;
            if (speed > speedlimit)
                Console.WriteLine("SLOW NOW");



            {


                bool istrue = true;
                if (istrue)
                {


                    Console.WriteLine("it is true");
                }
                else
                {
                    Console.WriteLine("it is false");
                    bool isTrue = false;
                    if (isTrue)
                    {
                        Console.WriteLine("it is true!");

                    }
                    else
                    {
                        Console.WriteLine("it is false!");

                    }



                }
            }
            {

                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32d) * 5d / 9d;
                double c;
                c = Math.Round(celsius, 0);
                if (fahrenheit < 40)
                { Console.WriteLine("it is cold!");
                    if (fahrenheit > 90)
                    { Console.WriteLine("it is hot!"); }




                    {
                        int product = 1;
                        while (product <= 10)
                        { Console.WriteLine($"{product}");
                            product = 1 + product;
                        }




                        {
                            int product = 60;
                            while (product >= 20)
                                Console.WriteLine($"{product}");
                            product = product - 1;

                        }

                        {
                            int product = 10;
                            while (product <= 20)
                            { Console.WriteLine($"{product}");
                                product = product + 1;

                        }



