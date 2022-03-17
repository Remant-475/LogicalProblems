using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems


{
    internal class Fibbonacci
    {
        public void FibbonacciSeries()
        {
            Console.WriteLine("Enter the Number");
            int Number = int.Parse(Console.ReadLine());

            int Num_a = 0;
            int Num_b = 1;
            int Sum;
            Console.Write(Num_a + " " + Num_b +" ");
            for (int i = 2; i < Number; i++) 
            {
                Sum = Num_a + Num_b;
                Console.Write(Sum + " ");
                Num_a = Num_b;
                Num_b = Sum;
            }
        }
    }
}
