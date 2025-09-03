using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Looping
{
    internal class WhileLoop
    {
        public void number()
        {
            int i = 1; // initilization

            while( i<=5) // condtion
            {
                Console.WriteLine(i);
                i++; // increment  so that i can increase from 1 to 5
            }
        }

        public void ReverseNumber()
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;
            }
            Console.WriteLine("Now the reverse number is " + reverse);
        }
    }
}
