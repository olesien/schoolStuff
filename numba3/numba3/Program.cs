using System;

namespace numba3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("total amount of people: ");
                int people = int.Parse(Console.ReadLine());
                Console.WriteLine("Allowed letters: V (left), H (right), A (EITHER), B (BOTH), I (NONE), example: BAVIABH ");
                Console.Write("Preferences: ");
                string pref = Console.ReadLine();
                bool left = true; //applies to first left only
                bool right = true;
                int happyFinal = 0;
                int happy = 0;
                //GÖR EN FOR LOOP SOM t.ex ändrar från först VHA, till HAV, till AVH
                //https://stackoverflow.com/questions/3222125/fastest-way-to-remove-first-char-in-a-string
                for (int times = 0; times < people; times++) {
                for (int i = 0; i < people; i++)
                {
                    string current = pref[i].ToString();
                    switch (current) 
                    {
                        case "V": //LEFT
                            if (right)
                            {
                                happy++;
                                if (i == 0)
                                {
                                    left = false;
                                }
                            }
                            break;
                        case "H": //RIGHT
                            if (!(i == people - 1) || left)
                            {
                                happy++;
                                right = false;
                            }
                            break;
                        case "A": //EITHER
                            if (right)
                            {

                                happy++;
                                if (i == 0)
                                {
                                    left = false;
                                }

                            }
                            else if (!(i == people - 1) || left)
                            {
                                happy++;
                                right = false;
                            }
                            break;
                        case "B": //BOTH ONLY, LAST TO CHOOSE?
                            /*if (right && (!(i == people - 1) || left))
                            {
                                happy++;
                                right = false;
                                if (i == 0)
                                {
                                    left = false;
                                }

                            }*/
                            break;
                        case "I": 
                            happy++;
                            right = true;
                            break;
                        default:
                            Console.WriteLine("Wrong preference sequence, illegal letters?");
                            break;


                    }
                        if (happy > happyFinal)
                        {
                            happyFinal = happy;
                        }
                    }
                    //Console.WriteLine(current);

                    Console.WriteLine(happy);
            }
        }
    }
}
