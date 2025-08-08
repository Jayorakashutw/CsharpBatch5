using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Operator
{
    internal class Ternary_Com_Log
    {
        //logical && (Logical And ) , || (Logical Or) , ! ( Logical Not)
        // Comparison -> ==, > ,>=, <,<=, !=

        // wap to accept 2 numbers and display greater one

        int num1, num2,num3, result;
        string output;
        public void Greatestin2()
        {
            Console.WriteLine("Enter 2 numbers ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            result = (num1>num2 ? num1 : num2); //

            Console.WriteLine("Greater number is "+result);
        }

        public void Greatestin3()
        {
            Console.WriteLine("Enter 3 numbers ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            result = (num1 > num2 && num1>num3) ? num1 : (num2>num1 && num2>num3)?num2:num3; //

            Console.WriteLine("Greater number in 3 is " + result);
        }

        //wap to accept age and check whether user can cast Vote or not
        public void CheckAge()
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            output = (age >= 18) ? "Hello, You can cast your vote" : "Sorry You Cant cast your vote";

            Console.WriteLine(output);
        }
        //wap to accept age and check whether age is valid or not (1 - 110)
        public void VerifyAge()
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            output = (age >= 1 && age<=110) ? "Hello, You age is Valid" : "Sorry You age is Invalid";

            Console.WriteLine(output);
        }

        //wap to accept salary and department of an Employee and Check whether Employee is eligible for Car or not salary must be greater than 60000 and department must be Sales

        public void CheckCarEligibility()
        {
            double salary;
            string department;

            Console.WriteLine("Enter Your Salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Department");
            department=Console.ReadLine();

            output = (salary >= 60000 || department.Equals("Sales",StringComparison.CurrentCultureIgnoreCase)) ? "Your are Eligible for Car" : "Not Eligible for Car";
            Console.WriteLine(output);
        }

    }
}
