using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_DamberPoudel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "1st january", "2nd february", "3rd march", "4th april", "5th may", "6th june", "7th july", "8th august", "9th september", "10th october", "11th november", "12th december" };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(months[i]);
            }
            //}
            //question 3

            string[] seasons = { "spring", "summer", "fall", "winter" };
            foreach (string season in seasons)
            {
                Console.WriteLine(season);

            }
            // }
            // question 4

            {
        int[] randomNumber = new int[1000];
        Random random = new Random();

        for (int i = 0; i < randomNumber.Length; i++)
            {
            randomNumber[i] = Random.Next(0, 100);
            }
     
            foreach (int i in randomNumber)
        {
        console.writeline(i.ToString());

    }

}

