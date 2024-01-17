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
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                    sum += i;
                }
                Console.WriteLine();

                Console.WriteLine($"Formula: {GetFormula(n)}");
                Console.WriteLine($"Output: {sum}");
            }
        }

        static string GetFormula(int n)
        {
            // Generating the formula string: 1+2+3+...+n
            string formula = "";
            for (int i = 1; i <= n; i++)
            {
                formula += i;
                if (i < n)
                {
                    formula += "+";
                }
            }
            return formula;
        }
    }
}
