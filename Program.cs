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
                Console.WriteLine("3. Find the Smallest Number in a List");
                Console.WriteLine("4. Count Positive and Negative Numbers");
                Console.WriteLine("5. Remove Duplicates from a List");
                Console.WriteLine("6. Find All Prime Numbers ");


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

                    case 2:
                        Console.WriteLine("Enter Number:");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 2 == 0)
                        {
                            Console.WriteLine("Even");
                        }
                        else
                        {
                            Console.WriteLine("Odd");
                        }

                        break;

                    case 3:
                        Console.WriteLine("How many Numbers you Needs:");
                        int N = int.Parse(Console.ReadLine());
                        int[] num = new int[N];

                        for (int i=0; i<N; i++)
                        {
                            Console.WriteLine("Enter Number:");
                            num[i] = int.Parse(Console.ReadLine());
                        }

                        int smallest = 0;
                        for (int i=0; i<N; i++)
                        {
                            if (num [i] < smallest)
                            {
                                smallest = num[i];
                            }
                        }

                        Console.WriteLine(" Smallest Number in the List is :" + smallest);

                        break;

                    case 4:
                        Console.WriteLine("How many Numbers you Needs:");
                        int NP = int.Parse(Console.ReadLine());
                        int[] NPnum = new int[NP];

                        for (int i = 0; i < NP; i++)
                        {
                            Console.WriteLine("Enter Number:");
                            NPnum[i] = int.Parse(Console.ReadLine());
                        }

                        int PositiveCount = 0;
                        int NegativeCount = 0;

                        for (int i = 0; i < NP; i++)
                        {
                            if (NPnum[i] > 0)
                            {
                                PositiveCount++;
                            }

                            else
                            {
                                NegativeCount++;
                            }
                        }

                        Console.WriteLine("Count of Positive Number in List is = " + PositiveCount);
                        Console.WriteLine("Count of Negative Number in List is = " + NegativeCount);

                        break;










                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
