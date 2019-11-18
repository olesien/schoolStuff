using System;
using System.Collections.Generic;
namespace Pro
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
                int lapAmount = int.Parse(Console.ReadLine());
                Console.Write("Price of laptop: ");
                int lapPrice = int.Parse(Console.ReadLine());
                if (lapPrice >= 1000 || lapPrice < 0)
                {
                    Console.WriteLine("Wrong laptop price");
                    continue;
                }

                Console.Write("Amount of stationary computers: ");
                int statAmount = int.Parse(Console.ReadLine());
                Console.Write("Price of stationary computers: ");
                int statPrice = int.Parse(Console.ReadLine());
                if (statPrice >= 1000 || statPrice < 0)
                {
                    Console.WriteLine("Wrong stationary price");
                    continue;
                }

                
      
                    Console.Write("How many sections are there?: ");
                    int section = int.Parse(Console.ReadLine());

                    int totalAmount = lapAmount + statAmount;
                    int totalPrice = lapPrice + statPrice;
                    int total = totalAmount * totalPrice;
                    int worth = 0;
                    var lap = new List<int>();
                    var stat = new List<int>();

                    for (int i = 0; i < section; i++)
                    {
                        lap.Add(0);
                        stat.Add(0);
                    }
                    lap[section-1] = lapAmount;
                    stat[section-1] = statAmount;

                    /*for (int i = 0; section < i; i++)
                    {
                        //int tempWorth = 0;
                        //here
                        if (List[i] < List[i - 1])
                        {
                            //3 är den största
                            //hitta en kombo där 3 får lite mer än 2 som får lite mer än 1
                            //
                            //while list[sista] < list[nästasista] < list[första]  )
                            //---
                            /*if (tempWorth > worth)
                            {
                                worth = tempWorth;
                            }
                        }
                    }*/

                    bool repeat = true;
                    while (repeat) {
                        //for loop here
                        int changes = 0;
                        for (int i = section-1; i > 0; i--) {
                        //int changes here
                        //if not adding the most valuable one will tip it over the line
                        if (statAmount > lapAmount) { //here we assume that stationary cost more, for example 500 dollars vs 300
                            if (((stat[i]-1)*statPrice + lap[i]*lapPrice) >= ((stat[i-1]+1)*statPrice + lap[i-1]*lapPrice) ) {
                                stat[i]--;
                                stat[-i]++;
                                changes++;
                            } else if (stat[i]*statPrice + (lap[i]-1)*lapPrice >= stat[i-1]*statPrice + (lap[i-1]-1)*lapPrice) {
                                lap[i]--;
                                lap[-i]++;
                                changes++;

                            }
                        } else if (lapAmount > statAmount) {
                            if (stat[i]*statPrice + (lap[i]-1)*lapPrice >= stat[i-1]*statPrice + (lap[i-1]-1)*lapPrice) {
                                lap[i]--;
                                lap[-i]++;
                                changes++;
                                } else if (((stat[i]-1)*statPrice + lap[i]*lapPrice) >= (stat[i-1]+1)*statPrice + lap[i-1]*lapPrice ) {
                                stat[i]--;
                                stat[-i]++;
                                changes++;
                            }
                        }
                        // else if not adding the least valuable one will tip it over
                        // else if removing one big (if there are any) and adding two small will not tip over
                        // else if changing one small for one big won't tip over
                        //in the for loop, there needs to be a counter, for every change that is made (aka one if statement true), it will have one added, changes++
                        }
                        if (changes == 0) {
                        repeat = false;
                        }
                        //after for loop, if changes = 0 repeat = false
                    }
                    Console.WriteLine(stat[0]);
                    Console.WriteLine(lap[0]);
                }
                

                //for (int i = )
            }
        }
    }

