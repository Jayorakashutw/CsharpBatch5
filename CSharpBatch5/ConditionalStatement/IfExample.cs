using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.ConditionalStatement
{
    internal class IfExample
    {
        //wap to accept age and check for Vote Validity
        int age,num1,num2,res,choice;
        char ch;

        public void VoteValidity()
        {
            Console.WriteLine("Enter Your Age");
            age=Convert.ToInt32(Console.ReadLine());

            if(age>=18)
            {
                Console.WriteLine("You are eligible for Vote");
            }
            else
            {
                Console.WriteLine("You are not eligible for Vote");
            }
        }

        //wap for simple calculator using ladder

        public void SimpleCalculator()
        {
            Console.WriteLine("Enter 2 nos");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice \n1. For Addition \n2. For Subtraction \n3. For Multiplication \n4. For Division");
            choice=Convert.ToInt32(Console.ReadLine());

            if(choice==1)
            {
                res = num1 + num2;
                Console.WriteLine("Sum is "+res);
            }
            else if(choice==2)
            {
                res = num1 - num2;
                Console.WriteLine("Sub is " + res);
            }
            else if(choice==3)
            {
                res = num1 * num2;
                Console.WriteLine("Mult is " + res);
            }
            else if(choice==4)
            {
                res = num1 / num2;
                Console.WriteLine("Divide is " + res);
            }
            else
            {
                Console.WriteLine(" Wrong Choice");
            }
        }

        public void SimpleCalculator1()
        {
            Console.WriteLine("Enter 2 nos");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your choice \n+. For Addition \n-. For Subtraction \n*. For Multiplication \n/. For Division");
            ch = Convert.ToChar(Console.ReadLine());  // KeyChar is used to directly capture a single character without pressing enter twice

            if (ch == '+')
            {
                res = num1 + num2;
                Console.WriteLine("Sum is " + res);
            }
            else
            {
                if (ch == '-')
                {
                    res = num1 - num2;
                    Console.WriteLine("Sub is " + res);
                }
                else
                {
                    if (ch == '*')
                    {
                        res = num1 * num2;
                        Console.WriteLine("Mult is " + res);
                    }
                    else
                    {
                        if (ch == '/')
                        {
                            res = num1 / num2;
                            Console.WriteLine("Divide is " + res);
                        }
                        else
                        {
                            Console.WriteLine(" Wrong Choice");
                        }
                    }
                }
            }
        }
    }
}
