using System;

namespace CSharpRampUp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a positive number for the pattern: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine("Number pattern using loop:");
                for (int i = n; i >= 1; i--)
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
