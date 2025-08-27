using CSharpBatch5.ConditionalStatement;
using CSharpBatch5.Looping;
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
            ForLoop fl = new ForLoop();
            fl.Factorial();
            //DoWhile wl = new DoWhile();
            //wl.number();

            Console.ReadKey();
        }
    }
}
