using System;

namespace Algorithem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Welcome to the Algorithm Program!");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Choose a Services You Need: ");
                Console.WriteLine("1. Calculate Average");
                Console.WriteLine("2. Check if a Number is Even or Odd");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter How Many Numbers you Need:");
                        int n = int.Parse(Console.ReadLine());

                        int[] numbers = new int[n];

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Enter Number:");
                            numbers[i] = int.Parse(Console.ReadLine());
                        }

                        int total = 0;
                        for (int i = 0; i < n; i++)
                        {
                            total += numbers[i];
                        }

                        float avg = (float)total / n;

                        Console.WriteLine("The Sum is = " + total);
                        Console.WriteLine("The Average is = " + avg);
                        break;



                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
