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

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 2)
            {
                for (int iteration = 0; iteration <= i.ToString().Length-1; iteration++)
                {
                    string tempi = i.ToString();
                    int tempiint = int.Parse(tempi[iteration].ToString());
                    array[tempiint] += 1;


                }
            }
            Console.WriteLine(array[0] + " " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5] + " " + array[6] + " " + array[7] + " " + array[8] + " " + array[9]);
            Console.ReadKey();


        }
    }
}
