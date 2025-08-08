using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Operator
{ 
    // = , +=, -=,*=, /= and %=
    public class AssignmentOperator
    {
        double num1, num2;
        public void Addition()
        {
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToDouble(Console.ReadLine()); //12
            num2 = Convert.ToDouble(Console.ReadLine());

            num1 += num2; //num1=num1+num2

            Console.WriteLine(" Sum of two number is " + num1);
        }
    }
}
