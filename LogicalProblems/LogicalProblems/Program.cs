using System;

namespace LogicalProblems
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter your Option");
            Console.WriteLine("Select 1: Fibonacci Series");

            int Option = int.Parse(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    Fibbonacci fibonaci = new Fibbonacci();
                    fibonaci.FibbonacciSeries();
                    break;

            }


        }
    }
}