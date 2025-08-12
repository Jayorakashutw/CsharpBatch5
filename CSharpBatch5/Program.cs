using CSharpBatch5.ConditionalStatement;
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
            JumpStatement js = new JumpStatement();
            js.EvenNo();

            Console.ReadKey();
        }
    }
}
