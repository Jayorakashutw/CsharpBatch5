using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Operator
{
    public class ArithmaticOperator
    {
        int num1,num2,result;
        //wap to accept 2 numbers and display its sum

        public void Addition()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32( Console.ReadLine()); //12
            num2 = Convert.ToInt32((Console.ReadLine()));

            result = num1 + num2;

            Console.WriteLine(" Sum of two number is "+result);
        }

        public void Subtraction()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine()); //12
            num2 = Convert.ToInt32((Console.ReadLine()));

            result = num1 - num2;

            Console.WriteLine($"Sub of two number is  {result}" );
        }

        public void Multiplication()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine()); //12
            num2 = Convert.ToInt32((Console.ReadLine()));

            result = num1 * num2;

            Console.WriteLine("Mult of two number is  {0}",result);
        }

        public static void Division()
        {
            int a = 45, b = 8;

            Console.WriteLine("Div value is "+(a/b));
        }
        //wap to accept 2 number and swap its value 

        public void Swapping1()
        {
            int temp;
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine()); //12
            num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Now Before swapping value is  {0}     {1}", num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Now after swapping value is  {0}     {1}", num1, num2);
            
        }
        //without using 3rd variable
        public void Swapping2()
        {
           
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine()); //12
            num2 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Now Before swapping value is  {0}     {1}", num1, num2);

            num1 = num1+num2;
            num2 = num1-num2;
            num1 = num1-num2;

            Console.WriteLine("Now after swapping value is  {0}     {1}", num1, num2);

        }
    }
}
