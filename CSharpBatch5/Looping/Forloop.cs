using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Looping
{
    internal class ForLoop
    {
        int num;

        //wap to display first 10 natural number
        public void NaturalNumber()
        {
            Console.WriteLine("First 10 Natural Number is below ");
            for (num = 1; num <= 10; num++)
            {
                Console.WriteLine(num);
            }
        }

        //wap to accept a number and display its table

        public void TableExample()
        {
            Console.WriteLine("Enter a number whose table you want");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Table of {0} is below ", num);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * num);
            }
        }

        //wap to accept a number and check whether it is prime or not 
        public void CheckPrime()
        {
            Console.WriteLine("Enter a number ");
            num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true; // assuming number is prime

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime NO");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
        }

        //wap to accept a number a reverse it

        public void ReverseNumber()
        {
            Console.WriteLine("Enter a number ");
            num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            for (; num > 0; num = num / 10)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
            }
            Console.WriteLine("Now the reverse number is " + reverse);
        }

        public void Factorial()
        {
            Console.WriteLine("Factorial of a number is below");
            num = 1;
            for (int i = 1; i <= 10; i++)
            {
                num = num * i;
            }
            Console.WriteLine("Factorial of 10 is " + num);
        }
    }
}