using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //array[0] += 1;
            //Console.WriteLine(array[0]);

            Console.Write("enter N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 2)
            {
                //Console.WriteLine("yes" + i.ToString().Length);
                for (int iteration = 0; iteration <= i.ToString().Length-1; iteration++)
                {
                    string tempi = i.ToString();
                    Console.WriteLine(tempi[iteration]);
                    //Console.WriteLine(tempi[iteration]);
                    //array[tempi[(it - 1)] - 1] += 1;
                    //Console.WriteLine(i.ToString()[it-1]);
                    //Console.WriteLine(": " + it);
                }
                //Console.WriteLine(i);
            }
            //Console.WriteLine(zero + " " + one + " " + two + " " + three + " " + four + " " + five + " " + six + " " + seven + " " + eight + " " + nine);
            //Console.WriteLine(array[0]);
            Console.ReadKey();


        }
    }
}
