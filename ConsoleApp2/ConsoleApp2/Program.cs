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
            int zero = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;
            int seven = 0;
            int eight = 0;
            int nine = 0;
            Console.Write("enter N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 2)
            {
                //Console.WriteLine("yes" + i.ToString().Length);
                for (int it = 1; it <= i.ToString().Length; it++)
                {
                    string tempi = i.ToString();
                    Console.WriteLine(tempi[(it - 1)]);
                    //Console.WriteLine(i.ToString()[it-1]);
                    //Console.WriteLine(": " + it);
                }
                //Console.WriteLine(i);
            }
            Console.WriteLine(zero + " " + one + " " + two + " " + three + " " + four + " " + five + " " + six + " " + seven + " " + eight + " " + nine);
            Console.ReadKey();


        }
    }
}
