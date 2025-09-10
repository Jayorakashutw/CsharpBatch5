using CSharpBatch5.ArrayExample;
using CSharpBatch5.ConditionalStatement;
using CSharpBatch5.Functions;
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
            Math_String ms = new Math_String();
            ms.MathFunction();
            //JaggedArray ja = new JaggedArray();
            //ja.JaggedArrayExample();
            //MultiArray ma = new MultiArray();
            //ma.TransposeMatrix();

            //ArrayBuiltInFunctions af = new ArrayBuiltInFunctions();
            //af.ArrayFunctionExample();

            Console.ReadKey();
        }
    }
}
