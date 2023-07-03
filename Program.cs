using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Deliverable_1__ISM_4300_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            string evenodd;

            try
            {

                while (true)
                {
                    Console.WriteLine("Enter an integer between 0 and 100: ");
                    input = int.Parse(Console.ReadLine());


                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                    Console.WriteLine("The entry is: " + input);
                }

                while (true)
                {
                    Console.WriteLine("Specify series (Even or Odd)");
                    evenodd = Console.ReadLine();

                    if (evenodd == "Even" || evenodd == "Odd")
                    {
                        break;
                    }

                }

                Console.WriteLine("You have selected the " + evenodd + " series. The numbers between 0 and " + input + " are: ");
                if (evenodd == "Odd")
                {
                    for (int i = 1; i <= input; i++)
                    {
                        if (i % 2 == 1)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }

                if (evenodd == "Even")
                {
                    for (int i = 1; i <= input; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }

                    }
                }
            }
            catch
            {
                Console.WriteLine("Enter a valid input");
            }
        }

    }
}