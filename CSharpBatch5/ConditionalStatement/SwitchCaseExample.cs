using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.ConditionalStatement
{
    internal class SwitchCaseExample
    {
        int age, num1, num2, res, choice;
        char ch;

        public void SimpleCalculator()
        {
            Console.WriteLine("Enter 2 nos");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice \n1. For Addition \n2. For Subtraction \n3. For Multiplication \n4. For Division");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1: 
                          res = num1 + num2;
                         Console.WriteLine("Sum of two number is "+res);
                         break;
                case 2: 
                        res = num1 - num2;
                         Console.WriteLine("Subtraction is " + res);
                         break;
                case 3:
                        res = num1 * num2;
                        Console.WriteLine("Multiplication is " + res);
                        break;
                case 4:
                        res = num1 / num2;
                        Console.WriteLine("Division is " + res);
                        break;
                default:
                        Console.WriteLine("Wrong Choice");
                        break;
            }
        }
        public void SimpleCalculator1()
        {
            Console.WriteLine("Enter 2 nos");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice \n+. For Addition \n-. For Subtraction \n*. For Multiplication \n/. For Division");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':
                    res = num1 + num2;
                    Console.WriteLine("Sum of two number is " + res);
                    break;
                case '-':
                    res = num1 - num2;
                    Console.WriteLine("Subtraction is " + res);
                    break;
                case '*':
                    res = num1 * num2;
                    Console.WriteLine("Multiplication is " + res);
                    break;
                case '/':
                    res = num1 / num2;
                    Console.WriteLine("Division is " + res);
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }
}
