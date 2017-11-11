using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTest_DamberPoudel
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            Boolean keeplooping = true;
            while (keeplooping)
            {
                if (i <= 11)
                    keeplooping = false;
                i++;
                Console.WriteLine(i);

            }
            //int i = 2
                while (i <= 128)
            {
                if ((i % 2 == 0))
                {
                    Console.WriteLine("[{0}]", i);
                }
                else if ((i % 2) != 0)
                {
                    Console.Write("");
                    
                }
                i *= 2;


            }
            {
                string j = ",";
                int i;
                for (i = 49; i >= 1; --i)
                {
                    Console.Write(i);
                    if (i >= 2)
                    {
                        Console.Write(j);

                    }
                }//question 4
                int i = 1;
                while (i <= 21)
                {
                    if ((i % 2) == 0)
                        Console.Write("   ");
                    else if ((i % 2) != 0)
                    {
                        Console.Write(i);

                    }
                    i++;

                    {
                        //question 5
                        int n = 8;
                        int i = 10;
                        while (i < n)
                        {
                            Console.Write("*");
                            i++;


                            {
                                // question 6
                                bool icyRain = false, tornadoWarning = false;
                                //bool tornadoWarning = false;
                                if (icyRain == false && tornadoWarning == false)
                                {
                                    Console.WriteLine("Let's go outside");

                                }
                            }
                    }
            }
 