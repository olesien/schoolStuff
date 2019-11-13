using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            int answer = 0;
            for (int current = 1; current <= N; current++)
            {
                answer += (current * current * current);
                Console.WriteLine(answer);
            }
            Console.ReadKey();
        }
    }
}
