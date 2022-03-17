using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PerfectNum
    {
        public void PerfectNumber()
        {
            int sum=0;

            Console.WriteLine("Enter the Number");
            int Num=int.Parse(Console.ReadLine());
            
            for (int i=1;i<Num;i++)
            {
                if (Num%i==0)
                {
                    sum+=i;
                }
            }
            if (sum==Num)
            {
                Console.WriteLine(Num + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(Num + " is not Perfect Number");
            }
        }
    }
}
