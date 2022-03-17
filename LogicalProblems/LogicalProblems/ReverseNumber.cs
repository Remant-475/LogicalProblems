using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            int rem, reverse = 0;
            Console.WriteLine("Enter the Number");
            int Num = int.Parse(Console.ReadLine());
            while (Num != 0)
            {
                rem = Num % 10;
                reverse = reverse * 10 + rem;
                Num = Num/10;
            }
            Console.WriteLine("Reverse Number is " + reverse);

        }
    }
}
