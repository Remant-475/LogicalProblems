﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicalProblems
{
    internal class PrimeNum
    {
        public void PrimeNumber()
        {
            
                int flag = 0;
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("{0} is not prime number", num);
                        flag = 1;
                        break;
                    }

                }
                if (flag == 0)
                {
                    Console.WriteLine("{0} is prime number", num);

                }
            }
        }
    }
