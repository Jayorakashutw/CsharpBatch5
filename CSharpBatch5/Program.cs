using CSharpBatch5.Operator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArithmaticOperator ao = new ArithmaticOperator();
           ao.Swapping2();
           // ao.Multiplication();
           // ArithmaticOperator.Division();

            Console.ReadKey();
        }
    }
}
