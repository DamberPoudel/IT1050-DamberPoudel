using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass10
{

    class GermanTranslator
    {
        public void sayHello()
        {
            Console.WriteLine("Guten Tag!");
        }

        public void sayGoodbye()
        {
            Console.WriteLine("Auf Wiedersehen");
        }
    }
    public void SayHello(string greetingType)
    {
        if (greetingType.ToLower() == "formal")
        {
            Console.WriteLine("Wie geht es Ihnen?");

        }

        else
        {
            Console.WriteLine("Wie geht es dir?");
        }
    }
    public bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;

        }
        return false;

    }//
}
public void sayGoodbye(int greetingtype)
{
    if (greetingtype == 1)
    {
        Console.WriteLine("Bis Spaeter!");

    }
    if (greetingtype ==2)
    {
        Console.WriteLine("Auf Wiedersehen");

    }
    if (greetingtype == 3)
    {
        Console.WriteLine("");
    }
}
