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
            while (true) { //loop
            int[] array = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //premade list

            Console.Write("Enter N: "); //to let user know what to type
            int n = int.Parse(Console.ReadLine()); //stores what users typed to a int variable converted from str

            for (int i = 1; i <= n; i += 2) //this it to go 1, 3, 5 etc
            {
                    //if number is more than one character (eg 11), it splits it to two 1's
                for (int iteration = 0; iteration <= i.ToString().Length-1; iteration++)

                {
                    string tempi = i.ToString(); //from number to string so that it can be counted
                    int tempiint = int.Parse(tempi[iteration].ToString()); //selects what numbers to use, for example 1 if 1
                    array[tempiint] += 1; //adding that to the list
                }
            }
            //write the list to the user
            Console.WriteLine(array[0] + " " + array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " " + array[5] + " " + array[6] + " " + array[7] + " " + array[8] + " " + array[9]);
            }


        }
    }
}
