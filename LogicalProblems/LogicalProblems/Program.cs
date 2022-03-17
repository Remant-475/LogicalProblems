using System;

namespace LogicalProblems
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter your Option");
            Console.WriteLine("Select 1: Fibonacci Series");
            Console.WriteLine("Select 2: Perfect NUmber");
            Console.WriteLine("Select 3: Prime Number");

            int Option = int.Parse(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    Fibbonacci fibonaci = new Fibbonacci();
                    fibonaci.FibbonacciSeries();
                    break;
                case 2:
                    PerfectNum Perfect = new PerfectNum();
                    Perfect.PerfectNumber();
                    break;
                case 3:
                    PrimeNum Prime = new PrimeNum();
                    Prime.PrimeNumber();
                    break;
            }


        }
    }
}