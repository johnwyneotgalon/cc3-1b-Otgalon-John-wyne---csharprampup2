using System;

namespace CSharpRampUp
{
    class Program
    {
        static void Main()
        {
            // Number pattern using loop
            Console.Write("Enter a positive number for the pattern (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine("Number pattern using loop:");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j} ");
                    }
                    Console.WriteLine();
                }

                // Sum of natural numbers using loop
                Console.Write("\nEnter a positive number to calculate the sum (m): ");
                int m = Convert.ToInt32(Console.ReadLine());

                if (m <= 0)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    Console.WriteLine($"Sum of natural numbers using loop:");
                    int sum = 0;
                    for (int i = 1; i <= m; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Sum: {sum}");

                    // Number pattern in reverse using loop
                    Console.Write("\nEnter a positive number for the reverse pattern (k): ");
                    int k = Convert.ToInt32(Console.ReadLine());

                    if (k <= 0)
                    {
                        Console.WriteLine("Invalid input");
                    }
                    else
                    {
                        Console.WriteLine("Reverse number pattern using loop:");
                        for (int i = k; i >= 1; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write($"{j} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
