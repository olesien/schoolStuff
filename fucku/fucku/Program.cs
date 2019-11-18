using System;
using System.Collections.Generic;

namespace fucku
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //En hierarchy, kan ej vara mer än 999 dollar värde på a och b
                //Vad vill jag göra? Jag vill göra ett system som för det första hittar antalet gånger den måste kolla om för att få max antal värde: loop 1: 1x300 -- 2x300+2x500, sen 1x500 3x300+1x500 tills den slutar på 2x300+2x500 -- 1x300
                // vid tre: 1x300 -- 1x500 -- 2x300+1x500
                // sedan 1x500 -- 1x300+1x300 -- 1x300 + 1x500
                Console.WriteLine("Welcome! Select amount of stationary computers and laptops, price can't go over 1,000 dollars per item");
                Console.Write("Amount of stationary computers: ");
                int statAmount = int.Parse(Console.ReadLine());
                Console.Write("Price of stationary computers: ");
                int statPrice = int.Parse(Console.ReadLine());
                if (statPrice >= 1000 || statPrice < 0)
                {
                    Console.WriteLine("Wrong stationary price");
                    continue;
                }

                Console.Write("Amount of laptops: ");
                int lapAmount = int.Parse(Console.ReadLine());
                Console.Write("Price of laptop: ");
                int lapPrice = int.Parse(Console.ReadLine());
                if (lapPrice >= 1000 || lapPrice < 0)
                {
                    Console.WriteLine("Wrong laptop price");
                    continue;
                }



                Console.Write("How many sections are there?: ");
                int section = int.Parse(Console.ReadLine());

                /*int totalAmount = lapAmount + statAmount;
                int totalPrice = lapPrice + statPrice;
                int total = totalAmount * totalPrice;*/
                //int worth = 0;
                var lap = new List<int>();
                var stat = new List<int>();

                for (int i = 0; i < section-1; i++)
                {
                    lap.Add(0);
                    stat.Add(0);
                }
                lap.Add(lapAmount);
                stat.Add(statAmount);

                //Console.WriteLine(lap[section-1]);
                //Console.ReadKey();

                    for (int i = section-1; i > 0; i--)
                    {
                    //Console.WriteLine(stat[i]);
                    //Console.WriteLine(stat[i-1]);
                    //int total = lap[i] * lapPrice + stat[i] * statPrice;
                    //int prevTotal = lap[i - 1] * lapPrice + stat[i - 1] * statPrice;

                    if (stat[i] % 2 == 0)
                        {
                        stat[i - 1] = ((stat[i] / 2)-1);
                        stat[i] -= stat[i - 1];
                    }
                        else
                        {
                        Console.WriteLine("yes");
                        stat[i - 1] = (stat[i] / 2);
                        stat[i] -= stat[i - 1];
                    }
                    //end

                    if (lap[i] % 2 == 0)
                    {
                        Console.WriteLine("yes");
                        lap[i - 1] = ((lap[i] / 2)-1);
                        lap[i] -= lap[i - 1];
                    }
                    else
                    {
                        lap[i - 1] = (lap[i] / 2);
                        lap[i] -= lap[i - 1];
                    }
                }
                int final = (lap[0] * lapPrice) + (stat[0] * statPrice);
                int finalTest = (lap[1] * lapPrice) + (stat[1] * statPrice);
                Console.WriteLine(stat[0]);
                Console.WriteLine(stat[1]);
                Console.WriteLine(lap[0]);
                Console.WriteLine(lap[1]);
                Console.WriteLine("Max worth: " + final);
                Console.WriteLine("Max worth test: " + finalTest);

                //for (int i = )
            }
        }
    }
}
