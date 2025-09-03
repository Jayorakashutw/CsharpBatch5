using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Looping
{
    internal class NestedLoop
    {
        //wap to display table of a range

        public void TableRange()
        {
            Console.WriteLine("Enter starting number");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"Table of {i} is:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        //wap to display all prime number between 1 to 100

        public void PrimeNumber()
        {
            Console.WriteLine("Prime numbers between 1 to 100 are:");
            for (int num = 2; num <= 100; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        //wap for pattern

        public void Pattern1()
        {
            Console.WriteLine("Patter is below");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        //wap for pattern 2

        public void Pattern2()
        {
            Console.WriteLine("Patter is below");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        //wap for pattern 3

        public void Pattern3()
        {
            Console.WriteLine("Patter is below");

            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= 5 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}