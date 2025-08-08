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
            Ternary_Com_Log tcl = new Ternary_Com_Log();
            tcl.CheckCarEligibility();

            Console.ReadKey();
        }
    }
}
